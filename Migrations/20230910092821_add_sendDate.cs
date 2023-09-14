using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailProject.DataLayer.Migrations
{
    public partial class add_sendDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SendDate",
                table: "Email",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendDate",
                table: "Email");
        }
    }
}
