using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFFilm_1.Migrations
{
    /// <inheritdoc />
    public partial class AjoutDesFilms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "ActeurPrincipal", "AnneeDeSortie", "Genre", "Realisateur", "Titre" },
                values: new object[,]
                {
                    { 2, "Robert De Niro", 1976, "Drame", "Martin Scorsese", "Taxi Driver" },
                    { 3, "Mark Hamill", 1977, "Science-Fiction", "George Lucas", "Star Wars: Episode IV" },
                    { 4, "Martin Sheen", 1979, "Guerre", "Francis Ford Coppola", "Apocalypse Now" },
                    { 5, "Sigourney Weaver", 1979, "Science-Fiction/Horreur", "Ridley Scott", "Alien" },
                    { 6, "Jack Nicholson", 1980, "Horreur", "Stanley Kubrick", "The Shining" },
                    { 7, "Harrison Ford", 1981, "Aventure", "Steven Spielberg", "Raiders of the Lost Ark" },
                    { 8, "Henry Thomas", 1982, "Science-Fiction", "Steven Spielberg", "E.T." },
                    { 9, "Harrison Ford", 1982, "Science-Fiction", "Ridley Scott", "Blade Runner" },
                    { 10, "Al Pacino", 1983, "Crime", "Brian De Palma", "Scarface" },
                    { 11, "Arnold Schwarzenegger", 1984, "Science-Fiction", "James Cameron", "Terminator" },
                    { 12, "Michael J. Fox", 1985, "Science-Fiction", "Robert Zemeckis", "Retour vers le futur" },
                    { 13, "Sigourney Weaver", 1986, "Science-Fiction/Action", "James Cameron", "Aliens" },
                    { 14, "Matthew Modine", 1987, "Guerre", "Stanley Kubrick", "Full Metal Jacket" },
                    { 15, "Bruce Willis", 1988, "Action", "John McTiernan", "Die Hard" },
                    { 16, "Michael Keaton", 1989, "Action", "Tim Burton", "Batman" },
                    { 17, "Ray Liotta", 1990, "Crime", "Martin Scorsese", "Les Affranchis" },
                    { 18, "Jodie Foster", 1991, "Thriller", "Jonathan Demme", "Le Silence des agneaux" },
                    { 19, "Harvey Keitel", 1992, "Crime", "Quentin Tarantino", "Reservoir Dogs" },
                    { 20, "Sam Neill", 1993, "Aventure", "Steven Spielberg", "Jurassic Park" },
                    { 21, "John Travolta", 1994, "Crime", "Quentin Tarantino", "Pulp Fiction" },
                    { 22, "Brad Pitt", 1995, "Thriller", "David Fincher", "Seven" },
                    { 23, "Frances McDormand", 1996, "Crime", "Joel Coen", "Fargo" },
                    { 24, "Leonardo DiCaprio", 1997, "Drame/Romance", "James Cameron", "Titanic" },
                    { 25, "Tom Hanks", 1998, "Guerre", "Steven Spielberg", "Il faut sauver le soldat Ryan" },
                    { 26, "Keanu Reeves", 1999, "Science-Fiction", "Lana et Lilly Wachowski", "Matrix" },
                    { 27, "Guy Pearce", 2000, "Thriller", "Christopher Nolan", "Memento" },
                    { 28, "Elijah Wood", 2001, "Fantasy", "Peter Jackson", "Le Seigneur des anneaux" },
                    { 29, "Alexandre Rodrigues", 2002, "Crime", "Fernando Meirelles", "City of God" },
                    { 30, "Uma Thurman", 2003, "Action", "Quentin Tarantino", "Kill Bill: Vol. 1" },
                    { 31, "Jim Carrey", 2004, "Drame/Romance", "Michel Gondry", "Eternal Sunshine" },
                    { 32, "Christian Bale", 2005, "Action", "Christopher Nolan", "Batman Begins" },
                    { 33, "Leonardo DiCaprio", 2006, "Crime", "Martin Scorsese", "Les Infiltrés" },
                    { 34, "Josh Brolin", 2007, "Crime", "Joel et Ethan Coen", "No Country for Old Men" },
                    { 35, "Christian Bale", 2008, "Action", "Christopher Nolan", "The Dark Knight" },
                    { 36, "Sam Worthington", 2009, "Science-Fiction", "James Cameron", "Avatar" },
                    { 37, "Leonardo DiCaprio", 2010, "Science-Fiction", "Christopher Nolan", "Inception" },
                    { 38, "Ryan Gosling", 2011, "Crime", "Nicolas Winding Refn", "Drive" },
                    { 39, "Jamie Foxx", 2012, "Western", "Quentin Tarantino", "Django Unchained" },
                    { 40, "Sandra Bullock", 2013, "Science-Fiction", "Alfonso Cuarón", "Gravity" },
                    { 41, "Matthew McConaughey", 2014, "Science-Fiction", "Christopher Nolan", "Interstellar" },
                    { 42, "Tom Hardy", 2015, "Action", "George Miller", "Mad Max: Fury Road" },
                    { 43, "Ryan Gosling", 2016, "Musical", "Damien Chazelle", "La La Land" },
                    { 44, "Daniel Kaluuya", 2017, "Horreur", "Jordan Peele", "Get Out" },
                    { 45, "Yalitza Aparicio", 2018, "Drame", "Alfonso Cuarón", "Roma" },
                    { 46, "Song Kang-ho", 2019, "Drame", "Bong Joon-ho", "Parasite" },
                    { 47, "Sylvester Stallone", 1976, "Drame", "John G. Avildsen", "Rocky" },
                    { 48, "Tim Robbins", 1994, "Drame", "Frank Darabont", "Les Évadés" },
                    { 49, "Brad Pitt", 1999, "Drame", "David Fincher", "Fight Club" },
                    { 50, "Russell Crowe", 2000, "Action", "Ridley Scott", "Gladiator" },
                    { 51, "Al Pacino", 1976, "Crime", "Francis Ford Coppola", "Le Parrain" },
                    { 52, "Tom Hanks", 1994, "Drame", "Robert Zemeckis", "Forrest Gump" },
                    { 53, "Keanu Reeves", 2003, "Science-Fiction", "Lana et Lilly Wachowski", "Matrix Reloaded" },
                    { 54, "Gerard Butler", 2006, "Action", "Zack Snyder", "300" },
                    { 55, "Christian Bale", 2006, "Drame", "Christopher Nolan", "Le Prestige" },
                    { 56, "Clint Eastwood", 2008, "Drame", "Clint Eastwood", "Gran Torino" },
                    { 57, "Sharlto Copley", 2009, "Science-Fiction", "Neill Blomkamp", "District 9" },
                    { 58, "Jesse Eisenberg", 2010, "Drame", "David Fincher", "The Social Network" },
                    { 59, "Leonardo DiCaprio", 2013, "Drame", "Martin Scorsese", "Le Loup de Wall Street" },
                    { 60, "Miles Teller", 2014, "Drame", "Damien Chazelle", "Whiplash" },
                    { 61, "Michael Keaton", 2015, "Drame", "Tom McCarthy", "Spotlight" },
                    { 62, "Amy Adams", 2016, "Science-Fiction", "Denis Villeneuve", "Premier Contact" },
                    { 63, "Frances McDormand", 2017, "Drame", "Martin McDonagh", "Three Billboards" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 63);
        }
    }
}
