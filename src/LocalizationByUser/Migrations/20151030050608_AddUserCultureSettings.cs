using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace LocalizationByUser.Migrations
{
    public partial class AddUserCultureSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Culture",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "UICulture",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Culture", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "UICulture", table: "AspNetUsers");
        }
    }
}
