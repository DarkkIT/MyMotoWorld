using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMotoWorld.Data.Migrations
{
    public partial class AddLikeColums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Liked",
                table: "MotorBikes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Liked",
                table: "BikeTypes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Liked",
                table: "MotorBikes");

            migrationBuilder.DropColumn(
                name: "Liked",
                table: "BikeTypes");
        }
    }
}
