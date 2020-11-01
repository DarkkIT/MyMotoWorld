namespace MyMotoWorld.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddBikeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BikeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Descrition = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoolingSystems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoolingSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrontBrake",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrontBrake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrontSuspension",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrontSuspension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RearBrake",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RearBrake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RearSuspension",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RearSuspension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    EngineCapacity = table.Column<int>(nullable: false),
                    EnginePower = table.Column<int>(nullable: false),
                    CoolingSystemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engine_CoolingSystems_CoolingSystemId",
                        column: x => x.CoolingSystemId,
                        principalTable: "CoolingSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MotorBikes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Model = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    SeatHeight = table.Column<int>(nullable: false),
                    BikeTypeId = table.Column<int>(nullable: false),
                    TransmissionId = table.Column<int>(nullable: false),
                    EngineId = table.Column<int>(nullable: false),
                    FrontSuspensionId = table.Column<int>(nullable: false),
                    RearSuspensionId = table.Column<int>(nullable: false),
                    FrontBrakesId = table.Column<int>(nullable: false),
                    RearBrakesId = table.Column<int>(nullable: false),
                    Descrition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorBikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorBikes_BikeTypes_BikeTypeId",
                        column: x => x.BikeTypeId,
                        principalTable: "BikeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotorBikes_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotorBikes_FrontBrake_FrontBrakesId",
                        column: x => x.FrontBrakesId,
                        principalTable: "FrontBrake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotorBikes_FrontSuspension_FrontSuspensionId",
                        column: x => x.FrontSuspensionId,
                        principalTable: "FrontSuspension",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotorBikes_RearBrake_RearBrakesId",
                        column: x => x.RearBrakesId,
                        principalTable: "RearBrake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotorBikes_RearSuspension_RearSuspensionId",
                        column: x => x.RearSuspensionId,
                        principalTable: "RearSuspension",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotorBikes_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<byte[]>(nullable: false),
                    MotorBikeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_MotorBikes_MotorBikeId",
                        column: x => x.MotorBikeId,
                        principalTable: "MotorBikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MotorBikeExtra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotorBikdeId = table.Column<int>(nullable: false),
                    MotorBikeId = table.Column<int>(nullable: true),
                    ExtraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorBikeExtra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorBikeExtra_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotorBikeExtra_MotorBikes_MotorBikeId",
                        column: x => x.MotorBikeId,
                        principalTable: "MotorBikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_CoolingSystemId",
                table: "Engine",
                column: "CoolingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_MotorBikeId",
                table: "Images",
                column: "MotorBikeId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikeExtra_ExtraId",
                table: "MotorBikeExtra",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikeExtra_MotorBikeId",
                table: "MotorBikeExtra",
                column: "MotorBikeId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikes_BikeTypeId",
                table: "MotorBikes",
                column: "BikeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikes_EngineId",
                table: "MotorBikes",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikes_FrontBrakesId",
                table: "MotorBikes",
                column: "FrontBrakesId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikes_FrontSuspensionId",
                table: "MotorBikes",
                column: "FrontSuspensionId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikes_RearBrakesId",
                table: "MotorBikes",
                column: "RearBrakesId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikes_RearSuspensionId",
                table: "MotorBikes",
                column: "RearSuspensionId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorBikes_TransmissionId",
                table: "MotorBikes",
                column: "TransmissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "MotorBikeExtra");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "MotorBikes");

            migrationBuilder.DropTable(
                name: "BikeTypes");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "FrontBrake");

            migrationBuilder.DropTable(
                name: "FrontSuspension");

            migrationBuilder.DropTable(
                name: "RearBrake");

            migrationBuilder.DropTable(
                name: "RearSuspension");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DropTable(
                name: "CoolingSystems");
        }
    }
}
