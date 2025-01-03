// See https://aka.ms/new-console-template for more information
using EFFilm_1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Un petit film ?");

Console.WriteLine(Directory.GetCurrentDirectory());

//Rechercher la connection à la base de données
IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
    .Build();

string cnstr = config.GetConnectionString("DEV");
DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseSqlServer(cnstr).Options;
MovieDBContext ctx = new MovieDBContext(dbContextOptions);

//MovieDBContext ctx = new MovieDBContext(cnstr);