namespace MyMotoWorld.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class MakeFavoritsEntitysDeleteble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FavoriteNews",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "FavoriteNews",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FavoriteNews",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "FavoriteNews",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FavoriteBikes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "FavoriteBikes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "FavoriteBikes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "FavoriteBikes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteNews_IsDeleted",
                table: "FavoriteNews",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBikes_IsDeleted",
                table: "FavoriteBikes",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FavoriteNews_IsDeleted",
                table: "FavoriteNews");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBikes_IsDeleted",
                table: "FavoriteBikes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FavoriteNews");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "FavoriteNews");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FavoriteNews");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "FavoriteNews");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FavoriteBikes");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "FavoriteBikes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "FavoriteBikes");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "FavoriteBikes");
        }
    }
}
