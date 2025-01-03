using EFFilm_1.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EFFilm_1.Configs
{
    public class FilmConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            /*Créer une classe Film. Chaque film sera définit par son titre (qui devra être unique), son année de sortie, son réalisateur, son acteur principal et son genre. 
Aucun des champs ne peut être nullable, et d’une taille max de 100 pour les string. 
Chaque film aura également un ID auto incrémenté et devra être sorti après 1975*/

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasIndex(x => x.Titre).IsUnique();
            builder.Property(x => x.Titre).IsRequired();
            builder.Property(x => x.Titre).HasMaxLength(100);

            builder.Property(x => x.AnneeDeSortie).IsRequired();
            // builder.HasCheckConstraint("CK_Annee", "AnneeDeSortie>1975");
            builder.ToTable(nameof(Movie), f => f.HasCheckConstraint("CK_Annee", "AnneeDeSortie>1975"));

            builder.Property(x => x.ActeurPrincipal).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Genre).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Realisateur).IsRequired().HasMaxLength(100);

#if DEBUG
            builder.HasData(
    new Movie { Id = 2, Titre = "Taxi Driver", AnneeDeSortie = 1976, Genre = "Drame", ActeurPrincipal = "Robert De Niro", Realisateur = "Martin Scorsese" },
    new Movie { Id = 3, Titre = "Star Wars: Episode IV", AnneeDeSortie = 1977, Genre = "Science-Fiction", ActeurPrincipal = "Mark Hamill", Realisateur = "George Lucas" },
    new Movie { Id = 4, Titre = "Apocalypse Now", AnneeDeSortie = 1979, Genre = "Guerre", ActeurPrincipal = "Martin Sheen", Realisateur = "Francis Ford Coppola" },
    new Movie { Id = 5, Titre = "Alien", AnneeDeSortie = 1979, Genre = "Science-Fiction/Horreur", ActeurPrincipal = "Sigourney Weaver", Realisateur = "Ridley Scott" },
    new Movie { Id = 6, Titre = "The Shining", AnneeDeSortie = 1980, Genre = "Horreur", ActeurPrincipal = "Jack Nicholson", Realisateur = "Stanley Kubrick" },
    new Movie { Id = 7, Titre = "Raiders of the Lost Ark", AnneeDeSortie = 1981, Genre = "Aventure", ActeurPrincipal = "Harrison Ford", Realisateur = "Steven Spielberg" },
    new Movie { Id = 8, Titre = "E.T.", AnneeDeSortie = 1982, Genre = "Science-Fiction", ActeurPrincipal = "Henry Thomas", Realisateur = "Steven Spielberg" },
    new Movie { Id = 9, Titre = "Blade Runner", AnneeDeSortie = 1982, Genre = "Science-Fiction", ActeurPrincipal = "Harrison Ford", Realisateur = "Ridley Scott" },
    new Movie { Id = 10, Titre = "Scarface", AnneeDeSortie = 1983, Genre = "Crime", ActeurPrincipal = "Al Pacino", Realisateur = "Brian De Palma" },
    new Movie { Id = 11, Titre = "Terminator", AnneeDeSortie = 1984, Genre = "Science-Fiction", ActeurPrincipal = "Arnold Schwarzenegger", Realisateur = "James Cameron" },
    new Movie { Id = 12, Titre = "Retour vers le futur", AnneeDeSortie = 1985, Genre = "Science-Fiction", ActeurPrincipal = "Michael J. Fox", Realisateur = "Robert Zemeckis" },
    new Movie { Id = 13, Titre = "Aliens", AnneeDeSortie = 1986, Genre = "Science-Fiction/Action", ActeurPrincipal = "Sigourney Weaver", Realisateur = "James Cameron" },
    new Movie { Id = 14, Titre = "Full Metal Jacket", AnneeDeSortie = 1987, Genre = "Guerre", ActeurPrincipal = "Matthew Modine", Realisateur = "Stanley Kubrick" },
    new Movie { Id = 15, Titre = "Die Hard", AnneeDeSortie = 1988, Genre = "Action", ActeurPrincipal = "Bruce Willis", Realisateur = "John McTiernan" },
    new Movie { Id = 16, Titre = "Batman", AnneeDeSortie = 1989, Genre = "Action", ActeurPrincipal = "Michael Keaton", Realisateur = "Tim Burton" },
    new Movie { Id = 17, Titre = "Les Affranchis", AnneeDeSortie = 1990, Genre = "Crime", ActeurPrincipal = "Ray Liotta", Realisateur = "Martin Scorsese" },
    new Movie { Id = 18, Titre = "Le Silence des agneaux", AnneeDeSortie = 1991, Genre = "Thriller", ActeurPrincipal = "Jodie Foster", Realisateur = "Jonathan Demme" },
    new Movie { Id = 19, Titre = "Reservoir Dogs", AnneeDeSortie = 1992, Genre = "Crime", ActeurPrincipal = "Harvey Keitel", Realisateur = "Quentin Tarantino" },
    new Movie { Id = 20, Titre = "Jurassic Park", AnneeDeSortie = 1993, Genre = "Aventure", ActeurPrincipal = "Sam Neill", Realisateur = "Steven Spielberg" },
    new Movie { Id = 21, Titre = "Pulp Fiction", AnneeDeSortie = 1994, Genre = "Crime", ActeurPrincipal = "John Travolta", Realisateur = "Quentin Tarantino" },
    new Movie { Id = 22, Titre = "Seven", AnneeDeSortie = 1995, Genre = "Thriller", ActeurPrincipal = "Brad Pitt", Realisateur = "David Fincher" },
    new Movie { Id = 23, Titre = "Fargo", AnneeDeSortie = 1996, Genre = "Crime", ActeurPrincipal = "Frances McDormand", Realisateur = "Joel Coen" },
    new Movie { Id = 24, Titre = "Titanic", AnneeDeSortie = 1997, Genre = "Drame/Romance", ActeurPrincipal = "Leonardo DiCaprio", Realisateur = "James Cameron" },
    new Movie { Id = 25, Titre = "Il faut sauver le soldat Ryan", AnneeDeSortie = 1998, Genre = "Guerre", ActeurPrincipal = "Tom Hanks", Realisateur = "Steven Spielberg" },
    new Movie { Id = 26, Titre = "Matrix", AnneeDeSortie = 1999, Genre = "Science-Fiction", ActeurPrincipal = "Keanu Reeves", Realisateur = "Lana et Lilly Wachowski" },
    new Movie { Id = 27, Titre = "Memento", AnneeDeSortie = 2000, Genre = "Thriller", ActeurPrincipal = "Guy Pearce", Realisateur = "Christopher Nolan" },
    new Movie { Id = 28, Titre = "Le Seigneur des anneaux", AnneeDeSortie = 2001, Genre = "Fantasy", ActeurPrincipal = "Elijah Wood", Realisateur = "Peter Jackson" },
    new Movie { Id = 29, Titre = "City of God", AnneeDeSortie = 2002, Genre = "Crime", ActeurPrincipal = "Alexandre Rodrigues", Realisateur = "Fernando Meirelles" },
    new Movie { Id = 30, Titre = "Kill Bill: Vol. 1", AnneeDeSortie = 2003, Genre = "Action", ActeurPrincipal = "Uma Thurman", Realisateur = "Quentin Tarantino" },
    new Movie { Id = 31, Titre = "Eternal Sunshine", AnneeDeSortie = 2004, Genre = "Drame/Romance", ActeurPrincipal = "Jim Carrey", Realisateur = "Michel Gondry" },
    new Movie { Id = 32, Titre = "Batman Begins", AnneeDeSortie = 2005, Genre = "Action", ActeurPrincipal = "Christian Bale", Realisateur = "Christopher Nolan" },
    new Movie { Id = 33, Titre = "Les Infiltrés", AnneeDeSortie = 2006, Genre = "Crime", ActeurPrincipal = "Leonardo DiCaprio", Realisateur = "Martin Scorsese" },
    new Movie { Id = 34, Titre = "No Country for Old Men", AnneeDeSortie = 2007, Genre = "Crime", ActeurPrincipal = "Josh Brolin", Realisateur = "Joel et Ethan Coen" },
    new Movie { Id = 35, Titre = "The Dark Knight", AnneeDeSortie = 2008, Genre = "Action", ActeurPrincipal = "Christian Bale", Realisateur = "Christopher Nolan" },
    new Movie { Id = 36, Titre = "Avatar", AnneeDeSortie = 2009, Genre = "Science-Fiction", ActeurPrincipal = "Sam Worthington", Realisateur = "James Cameron" },
    new Movie { Id = 37, Titre = "Inception", AnneeDeSortie = 2010, Genre = "Science-Fiction", ActeurPrincipal = "Leonardo DiCaprio", Realisateur = "Christopher Nolan" },
    new Movie { Id = 38, Titre = "Drive", AnneeDeSortie = 2011, Genre = "Crime", ActeurPrincipal = "Ryan Gosling", Realisateur = "Nicolas Winding Refn" },
    new Movie { Id = 39, Titre = "Django Unchained", AnneeDeSortie = 2012, Genre = "Western", ActeurPrincipal = "Jamie Foxx", Realisateur = "Quentin Tarantino" },
    new Movie { Id = 40, Titre = "Gravity", AnneeDeSortie = 2013, Genre = "Science-Fiction", ActeurPrincipal = "Sandra Bullock", Realisateur = "Alfonso Cuarón" },
    new Movie { Id = 41, Titre = "Interstellar", AnneeDeSortie = 2014, Genre = "Science-Fiction", ActeurPrincipal = "Matthew McConaughey", Realisateur = "Christopher Nolan" },
    new Movie { Id = 42, Titre = "Mad Max: Fury Road", AnneeDeSortie = 2015, Genre = "Action", ActeurPrincipal = "Tom Hardy", Realisateur = "George Miller" },
    new Movie { Id = 43, Titre = "La La Land", AnneeDeSortie = 2016, Genre = "Musical", ActeurPrincipal = "Ryan Gosling", Realisateur = "Damien Chazelle" },
    new Movie { Id = 44, Titre = "Get Out", AnneeDeSortie = 2017, Genre = "Horreur", ActeurPrincipal = "Daniel Kaluuya", Realisateur = "Jordan Peele" },
    new Movie { Id = 45, Titre = "Roma", AnneeDeSortie = 2018, Genre = "Drame", ActeurPrincipal = "Yalitza Aparicio", Realisateur = "Alfonso Cuarón" },
    new Movie { Id = 46, Titre = "Parasite", AnneeDeSortie = 2019, Genre = "Drame", ActeurPrincipal = "Song Kang-ho", Realisateur = "Bong Joon-ho" },
    new Movie { Id = 47, Titre = "Rocky", AnneeDeSortie = 1976, Genre = "Drame", ActeurPrincipal = "Sylvester Stallone", Realisateur = "John G. Avildsen" },
    new Movie { Id = 48, Titre = "Les Évadés", AnneeDeSortie = 1994, Genre = "Drame", ActeurPrincipal = "Tim Robbins", Realisateur = "Frank Darabont" },
    new Movie { Id = 49, Titre = "Fight Club", AnneeDeSortie = 1999, Genre = "Drame", ActeurPrincipal = "Brad Pitt", Realisateur = "David Fincher" },
    new Movie { Id = 50, Titre = "Gladiator", AnneeDeSortie = 2000, Genre = "Action", ActeurPrincipal = "Russell Crowe", Realisateur = "Ridley Scott" },
    new Movie { Id = 51, Titre = "Le Parrain", AnneeDeSortie = 1976, Genre = "Crime", ActeurPrincipal = "Al Pacino", Realisateur = "Francis Ford Coppola" },
    new Movie { Id = 52, Titre = "Forrest Gump", AnneeDeSortie = 1994, Genre = "Drame", ActeurPrincipal = "Tom Hanks", Realisateur = "Robert Zemeckis" },
    new Movie { Id = 53, Titre = "Matrix Reloaded", AnneeDeSortie = 2003, Genre = "Science-Fiction", ActeurPrincipal = "Keanu Reeves", Realisateur = "Lana et Lilly Wachowski" },
    new Movie { Id = 54, Titre = "300", AnneeDeSortie = 2006, Genre = "Action", ActeurPrincipal = "Gerard Butler", Realisateur = "Zack Snyder" },
    new Movie { Id = 55, Titre = "Le Prestige", AnneeDeSortie = 2006, Genre = "Drame", ActeurPrincipal = "Christian Bale", Realisateur = "Christopher Nolan" },
    new Movie { Id = 56, Titre = "Gran Torino", AnneeDeSortie = 2008, Genre = "Drame", ActeurPrincipal = "Clint Eastwood", Realisateur = "Clint Eastwood" },
    new Movie { Id = 57, Titre = "District 9", AnneeDeSortie = 2009, Genre = "Science-Fiction", ActeurPrincipal = "Sharlto Copley", Realisateur = "Neill Blomkamp" },
    new Movie { Id = 58, Titre = "The Social Network", AnneeDeSortie = 2010, Genre = "Drame", ActeurPrincipal = "Jesse Eisenberg", Realisateur = "David Fincher" },
    new Movie { Id = 59, Titre = "Le Loup de Wall Street", AnneeDeSortie = 2013, Genre = "Drame", ActeurPrincipal = "Leonardo DiCaprio", Realisateur = "Martin Scorsese" },
    new Movie { Id = 60, Titre = "Whiplash", AnneeDeSortie = 2014, Genre = "Drame", ActeurPrincipal = "Miles Teller", Realisateur = "Damien Chazelle" },
    new Movie { Id = 61, Titre = "Spotlight", AnneeDeSortie = 2015, Genre = "Drame", ActeurPrincipal = "Michael Keaton", Realisateur = "Tom McCarthy" },
    new Movie { Id = 62, Titre = "Premier Contact", AnneeDeSortie = 2016, Genre = "Science-Fiction", ActeurPrincipal = "Amy Adams", Realisateur = "Denis Villeneuve" },
    new Movie { Id = 63, Titre = "Three Billboards", AnneeDeSortie = 2017, Genre = "Drame", ActeurPrincipal = "Frances McDormand", Realisateur = "Martin McDonagh" }
                );
#endif

        }
    }
}
