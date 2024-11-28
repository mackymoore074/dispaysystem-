using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemModels.Migrations
{
    public partial class UpdateAgencyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastLogin" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3281), new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastLogin" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3286), new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3308), new DateTime(2024, 12, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 12, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3258), new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3261), new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 11, 26, 10, 45, 59, 147, DateTimeKind.Local).AddTicks(3266) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastLogin" },
                values: new object[] { new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8059), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastLogin" },
                values: new object[] { new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8065), new DateTime(2024, 11, 26, 9, 43, 3, 52, DateTimeKind.Local).AddTicks(8066) });

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
    }
}
