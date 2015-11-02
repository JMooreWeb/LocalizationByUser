using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace LocalizationByUser.Migrations
{
    public partial class AddDetailedUserCultureSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrencySymbol",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "en");
            migrationBuilder.AddColumn<string>(
                name: "LongDateFormat",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "ShortDateFormat",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CurrencySymbol", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Language", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "LongDateFormat", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "ShortDateFormat", table: "AspNetUsers");
        }
    }
}
