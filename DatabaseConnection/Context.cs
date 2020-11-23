using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
/*TODO V 48
 * måndag: lägga till bilder i Movies, få bort upprepning av data i tabellerna. 
 * tisdag: föreläsning
 * onsdag:GenreMovie, LeadActorMovie - tabellerna. 
 * torsdag: nörja med wpf
 * fredag: tenta
 */
namespace DatabaseConnection
{
    class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<LeadActor> LeadActors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(s => System.Diagnostics.Debug.WriteLine(s))
                .UseLazyLoadingProxies()
                .UseSqlServer(
                @"server=.\SQLExpress;" +
                @"database=RentalMovieDatabase;" +
                @"trusted_connection=true;" +
                @"MultipleActiveResultSets=True"
                );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
