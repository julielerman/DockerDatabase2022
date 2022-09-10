FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 5114


ENV ASPNETCORE_URLS=http://+:5114
# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["API/Agilistas.csproj", "API/"]
RUN dotnet restore "API/Agilistas.csproj"
COPY . .
WORKDIR "/src/API"
RUN dotnet build "Agilistas.csproj" -c Release -o /app

FROM build AS publish
# RUN dotnet publish "Agilistas.csproj" -c Release -o /app
RUN dotnet publish "Agilistas.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Agilistas.dll"]
