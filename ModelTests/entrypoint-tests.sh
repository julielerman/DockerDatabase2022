#!/bin/bash
set -eu -o pipefail
echo "in entrypoint-tests.sh"
sleep 12s
dotnet test ModelTests/ModelTests.csproj