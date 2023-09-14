using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailProject.DataLayer.Migrations
{
    public partial class add_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSend",
                table: "Email",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSend",
                table: "Email");
        }
    }
}
