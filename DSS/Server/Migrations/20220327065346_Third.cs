using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSS.Server.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carriers_Configurations_ConfigurationId",
                table: "Carriers");

            migrationBuilder.DropIndex(
                name: "IX_Carriers_ConfigurationId",
                table: "Carriers");

            migrationBuilder.DropColumn(
                name: "ConfigurationId",
                table: "Carriers");

            migrationBuilder.AddColumn<string>(
                name: "Carriers",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ControlFile",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Configurations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropColumn(
                name: "Carriers",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "Client",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "ControlFile",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Configurations");

            migrationBuilder.AddColumn<int>(
                name: "ConfigurationId",
                table: "Carriers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carriers_ConfigurationId",
                table: "Carriers",
                column: "ConfigurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carriers_Configurations_ConfigurationId",
                table: "Carriers",
                column: "ConfigurationId",
                principalTable: "Configurations",
                principalColumn: "Id");
        }
    }
}
