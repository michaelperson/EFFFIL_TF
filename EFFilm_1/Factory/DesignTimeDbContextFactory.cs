using EFFilm_1.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFilm_1.Factory
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MovieDBContext>
    {
        public MovieDBContext CreateDbContext(string[] args)
        {
            // Charger la configuration depuis appSettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false)
                .Build();

            // Obtenir la chaîne de connexion
            string connectionString=config.GetConnectionString("DEV");

            // Configurer les options du DbContext
            var optionsBuilder = new DbContextOptionsBuilder<MovieDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MovieDBContext(optionsBuilder.Options);
        }
    }
}
