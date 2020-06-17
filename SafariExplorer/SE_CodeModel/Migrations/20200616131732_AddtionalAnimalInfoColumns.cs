using Microsoft.EntityFrameworkCore.Migrations;

namespace SE_CodeModel.Migrations
{
    public partial class AddtionalAnimalInfoColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "AnimalsInfo");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AnimalsInfo");

            migrationBuilder.AddColumn<string>(
                name: "Diet",
                table: "AnimalsInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "AnimalsInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lifespan",
                table: "AnimalsInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mass",
                table: "AnimalsInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "AnimalsInfo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diet",
                table: "AnimalsInfo");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AnimalsInfo");

            migrationBuilder.DropColumn(
                name: "Lifespan",
                table: "AnimalsInfo");

            migrationBuilder.DropColumn(
                name: "Mass",
                table: "AnimalsInfo");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "AnimalsInfo");

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "AnimalsInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "AnimalsInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
