using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemModels.Migrations
{
    public partial class InitiaCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsItemBody = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Agency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImportanceLevel = table.Column<int>(type: "int", nullable: false),
                    MoreInformationUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgencyId = table.Column<int>(type: "int", nullable: true),
                    MenuItemsId = table.Column<int>(type: "int", nullable: true),
                    NewsItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Locations_MenuItems_MenuItemsId",
                        column: x => x.MenuItemsId,
                        principalTable: "MenuItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Locations_NewsItems_NewsItemId",
                        column: x => x.NewsItemId,
                        principalTable: "NewsItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AllowedIpAddress",
                columns: table => new
                {
                    IpAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    locationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedIpAddress", x => x.IpAddress);
                    table.ForeignKey(
                        name: "FK_AllowedIpAddress_Locations_locationId",
                        column: x => x.locationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgencyId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentEmployee",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEmployee", x => new { x.DepartmentsId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_DepartmentEmployee_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployee_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentNewsItem",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    NewsItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentNewsItem", x => new { x.DepartmentsId, x.NewsItemsId });
                    table.ForeignKey(
                        name: "FK_DepartmentNewsItem_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentNewsItem_NewsItems_NewsItemsId",
                        column: x => x.NewsItemsId,
                        principalTable: "NewsItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScreenType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastCheckedIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    StatusMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screens_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Screens_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    AgencyId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admins_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admins_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admins_Screens_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "Id", "DateCreated", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(7967), "Description for Agency1", "Agency1" },
                    { 2, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8004), "Description for Agency2", "Agency2" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "AgencyId", "DateCreated", "MenuItemsId", "Name", "NewsItemId" },
                values: new object[,]
                {
                    { 1, "123 Finance St", null, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8142), null, "Foothill (Finance)", null },
                    { 2, "456 HR Ave", null, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8144), null, "Main Office (HR)", null }
                });

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Id", "Agency", "DateCreated", "ImportanceLevel", "LastUpdated", "MoreInformationUrl", "NewsItemBody", "TimeOutDate", "Title" },
                values: new object[,]
                {
                    { 1, "Agency1", new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8173), 1, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8178), "http://example.com", "System maintenance scheduled.", new DateTime(2024, 12, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8175), "Important Update" },
                    { 2, "Agency2", new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8180), 2, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8183), "http://example.com", "New company policy in effect.", new DateTime(2024, 12, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8182), "New Policy" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "AgencyId", "DateCreated", "Description", "LocationId", "Name" },
                values: new object[] { 1, 1, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8127), "Finance Department", 1, "Finance" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "AgencyId", "DateCreated", "Description", "LocationId", "Name" },
                values: new object[] { 2, 2, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8130), "Human Resources Department", 2, "HR" });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "Id", "DateCreated", "DepartmentId", "IsOnline", "LastCheckedIn", "LastUpdated", "LocationId", "Name", "ScreenType", "StatusMessage" },
                values: new object[] { 1, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8154), 1, true, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8157), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8156), 1, "DM001", "LED", "Active" });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "Id", "DateCreated", "DepartmentId", "IsOnline", "LastCheckedIn", "LastUpdated", "LocationId", "Name", "ScreenType", "StatusMessage" },
                values: new object[] { 2, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8159), 2, true, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8161), 2, "LH002", "LCD", "Active" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AgencyId", "DateCreated", "DepartmentId", "Email", "FirstName", "LastLogin", "LastName", "LocationId", "PasswordHash", "Role", "ScreenId" },
                values: new object[] { 1, 1, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8107), 1, "johndoe@agency.com", "John", new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8109), "Doe", 1, "ade123", 1, 1 });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AgencyId", "DateCreated", "DepartmentId", "Email", "FirstName", "LastLogin", "LastName", "LocationId", "PasswordHash", "Role", "ScreenId" },
                values: new object[] { 2, 2, new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8112), 2, "janesmith@agency.com", "Jane", new DateTime(2024, 11, 25, 10, 6, 40, 455, DateTimeKind.Local).AddTicks(8113), "Smith", 2, "ade123", 0, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AgencyId",
                table: "Admins",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_DepartmentId",
                table: "Admins",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_LocationId",
                table: "Admins",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_ScreenId",
                table: "Admins",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_AllowedIpAddress_locationId",
                table: "AllowedIpAddress",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployee_EmployeesId",
                table: "DepartmentEmployee",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentNewsItem_NewsItemsId",
                table: "DepartmentNewsItem",
                column: "NewsItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AgencyId",
                table: "Departments",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_LocationId",
                table: "Departments",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_AgencyId",
                table: "Locations",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_MenuItemsId",
                table: "Locations",
                column: "MenuItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_NewsItemId",
                table: "Locations",
                column: "NewsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Screens_DepartmentId",
                table: "Screens",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Screens_LocationId",
                table: "Screens",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AllowedIpAddress");

            migrationBuilder.DropTable(
                name: "DepartmentEmployee");

            migrationBuilder.DropTable(
                name: "DepartmentNewsItem");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "Screens");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "NewsItems");
        }
    }
}
