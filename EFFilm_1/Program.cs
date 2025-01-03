// See https://aka.ms/new-console-template for more information
using EFFilm_1.Context;
using EFFilm_1.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

Console.WriteLine("Un petit film ?");
 
//Rechercher la connection à la base de données
IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
    .Build();

string cnstr = config.GetConnectionString("DEV");
DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseSqlServer(cnstr).Options;
using(MovieDBContext ctx = new MovieDBContext(dbContextOptions))
{
   //Parcourir les films
  // var MesMovies = ctx.Movies;
    //foreach(var m in MesMovies)
    //{
    //    Console.WriteLine(m.Titre);
    //}

    //Aller chercher un film avec l'id 35
    Movie? leTrenteCinq = ctx.Movies.SingleOrDefault(m => m.Id == 35);
    if( leTrenteCinq != null )
    Console.WriteLine($"Le 35ème movie : {leTrenteCinq.Titre}");

    //Aller chercher un film qui a comme acteur Harrison Ford
    Movie? HarrisonFord = ctx.Movies.FirstOrDefault(m => m.ActeurPrincipal == "Harrison Ford");
    if (HarrisonFord != null)
        Console.WriteLine($"Le HF movie : {HarrisonFord.Titre}");

    //Tous les films de Spielberg
    IQueryable<Movie> Spiel = ctx.Movies.Where(m => m.Realisateur == "Steven Spielberg");
    foreach (var item in Spiel)
    {
        Console.WriteLine($"Fiml de Spielberg : {item.Titre}");
    }

    //Selection ciblée
    IQueryable<string> lm = ctx.Movies.Select(item => item.Titre.ToUpper());

    //Autre sélection
    var lmidtitre = ctx.Movies.Select(item => new  { item.Id, titre = item.Titre.ToUpper() });

    //Et si j'appelais ma fonction :p
    var EFQuery = ctx.Movies.Select(item => new { item.Id, item.Titre}) ;
    var CSHARPIenum = EFQuery.ToList();
    var trandform = CSHARPIenum.Select(csharp => new { csharp.Id, titre = PremierLettre(csharp.Titre) });

    foreach (var fou in trandform)
    {
        Console.WriteLine(fou.titre);
    }

    //Ajouter
    //1 créer un objey
    Movie m = new Movie()
    {
        Titre = "Titanic Le Retour 2",
        ActeurPrincipal = "Leonardo Di Carpaccio",
        AnneeDeSortie = 2025,
        Genre = "Comédie SF",
        Realisateur = "Cabrone"

    };
    //2 Ajoute
    ctx.Movies.Add(m);

     

    //Modifier l'année de sortie du titanic
    Movie ToUpdate = ctx.Movies.SingleOrDefault(m => m.Titre == "Titanic");

    ToUpdate.AnneeDeSortie = 1982;


    //Supprimer le titanic 2 Le Retour
    Movie ToDel = ctx.Movies.SingleOrDefault(m => m.Titre == "Titanic Le Retour 2");
    ctx.Movies.Remove(m);



    //3 je save
    try
    {
        ctx.SaveChanges();
    }
    catch (DbUpdateException ex)
    {

        throw;
    }
}

static string PremierLettre(string titre)
{
    return titre[0].ToString().ToUpper() + titre.Substring(1);
}


