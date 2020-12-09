namespace MyMotoWorld.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddFavoriteBikesAndNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteBikes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotorBikeId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteBikes_MotorBikes_MotorBikeId",
                        column: x => x.MotorBikeId,
                        principalTable: "MotorBikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoriteBikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteNews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteNews_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoriteNews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBikes_MotorBikeId",
                table: "FavoriteBikes",
                column: "MotorBikeId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBikes_UserId",
                table: "FavoriteBikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteNews_NewsId",
                table: "FavoriteNews",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteNews_UserId",
                table: "FavoriteNews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteBikes");

            migrationBuilder.DropTable(
                name: "FavoriteNews");
        }
    }
}
