namespace MyMotoWorld.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ChangeFavoriteBikeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FavoriteBikes_IsDeleted",
                table: "FavoriteBikes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "FavoriteBikes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FavoriteBikes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "FavoriteBikes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FavoriteBikes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBikes_IsDeleted",
                table: "FavoriteBikes",
                column: "IsDeleted");
        }
    }
}
