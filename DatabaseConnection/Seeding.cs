
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace DatabaseConnection
{
    class Seeding
    {
        static void Main()
        {
            using (var ctx = new Context())
            {
                ctx.RemoveRange(ctx.Customers);
                ctx.RemoveRange(ctx.Movies);
                ctx.RemoveRange(ctx.Rentals);
                ctx.RemoveRange(ctx.Genres);
                ctx.RemoveRange(ctx.LeadActors);

                ctx.AddRange(new List<Customer> //Jens
                {
                    new Customer { Email = "kalleabdul@hotmail.com", FirstName = "Kalle", LastName = "Abdul", Birthday = "1988-04-01"},
                    new Customer { Email = "kevab@gmail.com", FirstName = "Kevin", LastName = "Aban", Birthday = "1991-12-29"},
                    new Customer { Email = "christine.lofberg@telia.com", FirstName = "Christine", LastName = "Löfberg", Birthday = "1960-05-14"},
                    new Customer { Email = "emelie.s.smith@gmail.com", FirstName = "Emelie", LastName = "Smith", Birthday = "1997-01-23"},
                    new Customer { Email = "jocke_starfighter@yahoo.com", FirstName = "Joakim", LastName = "Stjernfeldt", Birthday = "1977-08-22"}

                });

                var Movies = new List<Movie>();
                var lines = File.ReadAllLines(@""); // vet ej hur jag skriver rätt patch... 
                                                    //(hela path = C:\Users\Johan\source\repos\projektDatalagring\DatabaseConnection\SeedData\MovieGenre.csv )
                
                { 
                    new Movie { Title = "The Shawshank Redemption", Year = 1994, ImbdRating = , ImageURL = "" },
                    new Movie { Title = "Schindler's List", Year = 1993, ImbdRating =, ImageURL = "" },
                    new Movie { Title = "Pulp Fiction", Year = 1994, ImbdRating = , ImageURL = "" },
                    new Movie { Title = "The Good, the Bad and the Ugly", Year = 1966, ImbdRating =, ImageURL = "" },
                    new Movie { Title = "Flight Club", Year = 1999, ImbdRating =, ImageURL = "" },
                    new Movie { Title = "Saving Private Ryan", Year = 1998, ImbdRating = , ImageURL = "" },
                    new Movie { Title = "Goodfellas", Year = 1990, ImbdRating = , ImageURL = "" }


                });  


                ctx.AddRange(new List<Rental> // Jens
                {
                    new Rental { RentalDate = "2020-10-19"},
                    new Rental { RentalDate = "2020-10-31"},
                    new Rental { RentalDate = "2020-10-31"},
                    new Rental { RentalDate = "2020-11-01"},
                    new Rental { RentalDate = "2020-11-10"}
                }) ;

                ctx.AddRange(new List<Genre> // Jens
                { 
                    new Genre { GenreName = "Crime" },
                    new Genre { GenreName = "Action" },
                    new Genre { GenreName = "Biography" },
                    new Genre { GenreName = "Drama" },
                    new Genre { GenreName = "Western" }
                });



                ctx.AddRange(new List<LeadActor> // Johanna
                {

                });

                ctx.SaveChanges();
            }
        
        }
    }
}
