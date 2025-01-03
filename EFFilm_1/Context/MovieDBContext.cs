using EFFilm_1.Configs;
using EFFilm_1.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFilm_1.Context
{
    public class MovieDBContext : DbContext
    {
        private readonly string cnstr;
        
        public MovieDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //apply configuration
            modelBuilder.ApplyConfiguration<Movie>(new FilmConfig());
        }
    }
}
