using Microsoft.EntityFrameworkCore;
using Mission06_AnnabelleBaker;

namespace Mission06_AnnabelleBaker.Models
{
        public class MovieContext : DbContext // bringing in from EntityFrameworkCore packages, : means inheritance
        {
            public MovieContext(DbContextOptions<MovieContext> options) : base(options) // constructor to set up options
            {

            }

        
            public DbSet<Movie> Movies { get; set; } // create database set, Movies is table name

            public DbSet<Category> Categories { get; set; } // create database set, Categories is table name  

            protected override void OnModelCreating(ModelBuilder modelBuilder) // seed data
            {
                modelBuilder.Entity<Category>().HasData(
                    
                    new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
                    new Category { CategoryId = 2, CategoryName = "Drama" },
                    new Category { CategoryId = 3, CategoryName = "Television" },
                    new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
                    new Category { CategoryId = 5, CategoryName = "Comedy" },
                    new Category { CategoryId = 6, CategoryName = "Family" },
                    new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
                    new Category { CategoryId = 8, CategoryName = "VHS" });
            }





        }




}


