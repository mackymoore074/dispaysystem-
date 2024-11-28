using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemModels.Migrations
{
    public partial class UpdateRoleEnumAndOtherChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastLogin", "Role" },
                values: new object[] { new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8059), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8061), 2 });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastLogin", "Role" },
                values: new object[] { new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8065), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8066), 1 });

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8084), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 12, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8096), new DateTime(2024, 12, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8037), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8043), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8045) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastLogin", "Role" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8109), 1 });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastLogin", "Role" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8112), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8113), 0 });

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8173), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 12, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 12, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8154), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8157), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8159), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8161) });
        }
    }
}
