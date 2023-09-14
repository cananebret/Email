using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailProject.DataLayer.Migrations
{
    public partial class duzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAdress",
                table: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAdress",
                table: "Email",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
