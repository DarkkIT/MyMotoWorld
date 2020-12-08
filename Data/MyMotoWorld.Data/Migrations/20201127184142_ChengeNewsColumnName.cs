namespace MyMotoWorld.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ChengeNewsColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImagePath",
                table: "News");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "News");

            migrationBuilder.AddColumn<string>(
                name: "MainImagePath",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
