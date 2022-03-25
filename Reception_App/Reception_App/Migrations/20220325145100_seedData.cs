﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reception_App.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    MeetingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.MeetingID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StaffMeetingAttendance",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendeeID = table.Column<int>(type: "int", nullable: false),
                    MeetingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMeetingAttendance", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VisitorMeetingAttendance",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendeeID = table.Column<int>(type: "int", nullable: false),
                    MeetingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorMeetingAttendance", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Meetings",
                column: "MeetingID",
                values: new object[]
                {
                    new Guid("1aa51e3c-c6c2-4e34-9d94-a54cdc6416cd"),
                    new Guid("eca328b7-132f-4180-b7b8-34c04e87a265")
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "ID", "Company", "ContactNumber", "Email", "Name", "Role" },
                values: new object[,]
                {
                    { 1, "WTC", "0000000000", "shakirah@wethinkcode.co.za", "Shakirah Brittle", "Campus Coordinator" },
                    { 2, "WTC", "1111111111", "awesome@wethinkcode.co.za", "Awesome Flan", "Senior Developer" },
                    { 3, "WTC", "2222222222", "ruin@wethinkcode.co.za", "Ruin the Beer", "Student Performance" },
                    { 4, "WTC", "3333333333", "durian@wethinkcode.co.za", "Durian Woof", "Senior Developer" },
                    { 5, "WTC", "4444444444", "ready@wethinkcode.co.za", "Ready Sett Go", "Senior Developer" }
                });

            migrationBuilder.InsertData(
                table: "StaffMeetingAttendance",
                columns: new[] { "ID", "AttendeeID", "MeetingID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("1aa51e3c-c6c2-4e34-9d94-a54cdc6416cd") },
                    { 2, 2, new Guid("1aa51e3c-c6c2-4e34-9d94-a54cdc6416cd") },
                    { 3, 1, new Guid("eca328b7-132f-4180-b7b8-34c04e87a265") }
                });

            migrationBuilder.InsertData(
                table: "VisitorMeetingAttendance",
                columns: new[] { "ID", "AttendeeID", "MeetingID" },
                values: new object[,]
                {
                    { 1, 1, new Guid("1aa51e3c-c6c2-4e34-9d94-a54cdc6416cd") },
                    { 2, 2, new Guid("eca328b7-132f-4180-b7b8-34c04e87a265") }
                });

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "ID", "Company", "ContactNumber", "Email", "Name", "Role" },
                values: new object[,]
                {
                    { 1, "CoolTechStartup", "1234567890", "investor@cooltech.co.za", "Potential Investor", "CEO" },
                    { 2, "CoolTechStartup", "1112131415", "prev@cooltech.co.za", "Prev Student", "Junior developer" },
                    { 3, "CoolTechStartup", "1617181920", "koel@cooltech.co.za", "Koel Thum", "Junior developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "StaffMeetingAttendance");

            migrationBuilder.DropTable(
                name: "VisitorMeetingAttendance");

            migrationBuilder.DropTable(
                name: "Visitors");
        }
    }
}
