using Microsoft.EntityFrameworkCore;
using Mission06_AnnabelleBaker;

namespace Mission06_AnnabelleBaker.Models
{
        public class MoviesContext : DbContext // bringing in from EntityFrameworkCore packages, : means inheritance
        {
            public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) // constructor to set up options
            {
            }

            public DbSet<Movies> Movies { get; set; } // create database set, Movies is table name
        }
}

