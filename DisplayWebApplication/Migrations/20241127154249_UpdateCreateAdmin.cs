using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemModels.Migrations
{
    public partial class UpdateCreateAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Agencies_AgencyId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Departments_DepartmentId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Locations_LocationId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Screens_ScreenId",
                table: "Admins");

            migrationBuilder.AlterColumn<int>(
                name: "ScreenId",
                table: "Admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AgencyId",
                table: "Admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AgencyId", "DateCreated", "DepartmentId", "LastLogin", "LocationId", "ScreenId" },
                values: new object[] { null, new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3864), null, new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3864), null, null });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AgencyId", "DateCreated", "DepartmentId", "LastLogin", "LocationId", "ScreenId" },
                values: new object[] { null, new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3866), null, new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3866), null, null });

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3910), new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3920), new DateTime(2024, 12, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated", "TimeOutDate" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3921), new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3923), new DateTime(2024, 12, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3846), new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3847), new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastCheckedIn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3849), new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3850), new DateTime(2024, 11, 27, 15, 42, 49, 472, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Agencies_AgencyId",
                table: "Admins",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Departments_DepartmentId",
                table: "Admins",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Locations_LocationId",
                table: "Admins",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Screens_ScreenId",
                table: "Admins",
                column: "ScreenId",
                principalTable: "Screens",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Agencies_AgencyId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Departments_DepartmentId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Locations_LocationId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Screens_ScreenId",
                table: "Admins");

            migrationBuilder.AlterColumn<int>(
                name: "ScreenId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgencyId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AgencyId", "DateCreated", "DepartmentId", "LastLogin", "LocationId", "ScreenId" },
                values: new object[] { 1, new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4874), 1, new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4876), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AgencyId", "DateCreated", "DepartmentId", "LastLogin", "LocationId", "ScreenId" },
                values: new object[] { 2, new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4879), 2, new DateTime(2024, 11, 26, 11, 42, 1, 664, DateTimeKind.Local).AddTicks(4880), 2, 2 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Departments_DepartmentId",
                table: "Admins",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Locations_LocationId",
                table: "Admins",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Screens_ScreenId",
                table: "Admins",
                column: "ScreenId",
                principalTable: "Screens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
