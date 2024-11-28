using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemModels.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Agencies_AgencyId",
                table: "Admins");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastLogin" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4874), new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastLogin" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4879), new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4894), new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 12, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4900), new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4904), new DateTime(2024, 12, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4822), new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4825), new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Agencies_AgencyId",
                table: "Admins",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Agencies_AgencyId",
                table: "Admins");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Agencies_AgencyId",
                table: "Admins",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
