using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipesASPCoreMVCWebApp.Data.Migrations
{
    public partial class initialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(nullable: true),
                    RecipeCat = table.Column<string>(nullable: true),
                    RecipeDate = table.Column<DateTime>(nullable: false),
                    ingredients = table.Column<string>(nullable: true),
                    PrepMtd = table.Column<string>(nullable: true),
                    PrepTime = table.Column<int>(nullable: false),
                    CookingTime = table.Column<int>(nullable: false),
                    Servings = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
