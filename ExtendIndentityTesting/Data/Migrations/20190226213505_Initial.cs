using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExtendIndentityTesting.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "APPEMAIL",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "APPPHONENUM",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "APPUSERNAME",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FULLNAME",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PASSWORD",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PROFESSIONALNRC",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PROFESSIONALPHOTO",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PROFESSIONALSIGN",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "APPEMAIL",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "APPPHONENUM",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "APPUSERNAME",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FULLNAME",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PASSWORD",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PROFESSIONALNRC",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PROFESSIONALPHOTO",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PROFESSIONALSIGN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");
        }
    }
}
