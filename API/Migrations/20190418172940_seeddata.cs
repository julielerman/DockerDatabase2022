using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agilistas.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("167d1f6b-a93d-49e4-8a0d-e651369e018b"), "Agile Testing" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("5f6d6f80-9f9a-469e-9036-07ecbb3971ea"), "Exploratory Testing" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description" },
                values: new object[] { new Guid("c5b6a0e8-e43f-4765-906f-e15e019a19d8"), "Psychology of Collaboration" });

            migrationBuilder.InsertData(
                table: "Agilistas",
                columns: new[] { "Id", "Name", "PrimaryFocusId", "TwitterHandle" },
                values: new object[,]
                {
                    { new Guid("5efdb55d-1205-419f-8a0b-9cc7a15f8565"), "Lisa Crispin", new Guid("167d1f6b-a93d-49e4-8a0d-e651369e018b"), null },
                    { new Guid("554be900-d1a4-4908-9d6a-5ef3ea05650e"), "Janet Gregory", new Guid("167d1f6b-a93d-49e4-8a0d-e651369e018b"), null },
                    { new Guid("f2e5fdba-daf9-43f0-8bde-9ed2562bd12a"), "Maaret Pyhäjärvi", new Guid("5f6d6f80-9f9a-469e-9036-07ecbb3971ea"), null },
                    { new Guid("83eda86f-c652-4666-ba17-db90b218a54b"), "Linda Rising", new Guid("c5b6a0e8-e43f-4765-906f-e15e019a19d8"), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("554be900-d1a4-4908-9d6a-5ef3ea05650e"));

            migrationBuilder.DeleteData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("5efdb55d-1205-419f-8a0b-9cc7a15f8565"));

            migrationBuilder.DeleteData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("83eda86f-c652-4666-ba17-db90b218a54b"));

            migrationBuilder.DeleteData(
                table: "Agilistas",
                keyColumn: "Id",
                keyValue: new Guid("f2e5fdba-daf9-43f0-8bde-9ed2562bd12a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("167d1f6b-a93d-49e4-8a0d-e651369e018b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f6d6f80-9f9a-469e-9036-07ecbb3971ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5b6a0e8-e43f-4765-906f-e15e019a19d8"));
        }
    }
}
