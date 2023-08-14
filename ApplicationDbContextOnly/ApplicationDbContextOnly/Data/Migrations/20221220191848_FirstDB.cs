using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationDbContextOnly.Data.Migrations
{
    public partial class FirstDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<byte>(type: "tinyint", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EducationPath = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Complex = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Stage = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<byte>(type: "tinyint", nullable: false),
                    JobArName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobEnName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorId = table.Column<byte>(type: "tinyint", nullable: false),
                    MajorArName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, collation: "Arabic_CI_AS"),
                    MajorEnName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorId);
                });

            migrationBuilder.CreateTable(
                name: "PhotoCopyCenters",
                columns: table => new
                {
                    PhotoCopyCenterId = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, collation: "Arabic_CI_AS"),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, collation: "Arabic_CI_AS"),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')", collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Mobile = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false, defaultValueSql: "('')", collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Phone = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false, defaultValueSql: "('')", collation: "SQL_Latin1_General_CP1_CI_AS"),
                    IsDefaultForApplicationDbContextOnly = table.Column<bool>(type: "bit", unicode: false, nullable: false, defaultValueSql: "0"),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoCopyCenters", x => x.PhotoCopyCenterId);
                    table.ForeignKey(
                        name: "FK_PhotoCopyCenters_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DepartmentId = table.Column<byte>(type: "tinyint", nullable: false),
                    IsDepartmentManager = table.Column<bool>(type: "bit", nullable: false),
                    JobId = table.Column<byte>(type: "tinyint", nullable: false),
                    MajorId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "MajorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    PhysicalFileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    UploadDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileId", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Files_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrintOrders",
                columns: table => new
                {
                    PrintOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PhotoCopyCenterId = table.Column<byte>(type: "tinyint", nullable: false),
                    OrderNumber = table.Column<long>(type: "bigint", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    PrintOrderName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OrderRegisterDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PageSize = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    Color = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false, collation: "Arabic_CI_AS"),
                    Orientation = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    PrintSide = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, collation: "Arabic_CI_AS"),
                    PagesPerPaper = table.Column<byte>(type: "tinyint", nullable: false),
                    CountOfCopies = table.Column<byte>(type: "tinyint", nullable: false),
                    Stapling = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, collation: "Arabic_CI_AS"),
                    CoveringType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PagesZoom = table.Column<byte>(type: "tinyint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true, collation: "Arabic_CI_AS"),
                    DepartmentManagerDecision = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    DepartmentManagerLastActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrintManagerDecision = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PrintManageLastActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhotoCopyCenterState = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhotoCopyCenterLastActionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintOrder_PrintOrderId", x => x.PrintOrderId);
                    table.ForeignKey(
                        name: "FK_PrintOrders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrintOrders_PhotoCopyCenters_PhotoCopyCenterId",
                        column: x => x.PhotoCopyCenterId,
                        principalTable: "PhotoCopyCenters",
                        principalColumn: "PhotoCopyCenterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c94eb536-cba2-4d3e-95e5-148277072706", "c94eb536-cba2-4d3e-95e5-148277072706", "Users", "USERS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c5ea8c3-1ba4-4845-b173-e874682de4f2", "7c5ea8c3-1ba4-4845-b173-e874682de4f2", "Admins", "ADMINS" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "326aaa65-f69d-48ca-8bb7-031bb7fb8abb", 0, "0b8ddcf0-452f-4f0a-82b3-3dde685b1375", "sysadmin@sysadmin.com", true, false, null, "SYSADMIN@SYSADMIN.COM", "SYSADMIN@SYSADMIN.COM", "AQAAAAEAACcQAAAAEMEo0/1kIHUPHUEO0/qs5k4LgjmW6DplQ9+rraq03Ws5+oceRgvf7TAWcDvvz3sNNA==", "21dcfa2c-033c-4b8b-affc-98a16efd4f91", false, "sysadmin@sysadmin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7c5ea8c3-1ba4-4845-b173-e874682de4f2", "326aaa65-f69d-48ca-8bb7-031bb7fb8abb" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobId",
                table: "Employees",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MajorId",
                table: "Employees",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Files_EmployeeId",
                table: "Files",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoCopyCenters_UserId",
                table: "PhotoCopyCenters",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrintOrders_EmployeeId",
                table: "PrintOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PrintOrders_PhotoCopyCenterId",
                table: "PrintOrders",
                column: "PhotoCopyCenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "PrintOrders");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "PhotoCopyCenters");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c94eb536-cba2-4d3e-95e5-148277072706");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c5ea8c3-1ba4-4845-b173-e874682de4f2", "326aaa65-f69d-48ca-8bb7-031bb7fb8abb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c5ea8c3-1ba4-4845-b173-e874682de4f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "326aaa65-f69d-48ca-8bb7-031bb7fb8abb");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
