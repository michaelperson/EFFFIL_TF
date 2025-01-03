using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFFilm_1.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AnneeDeSortie = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActeurPrincipal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Realisateur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.CheckConstraint("CK_Annee", "AnneeDeSortie>1975");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Titre",
                table: "Movie",
                column: "Titre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
