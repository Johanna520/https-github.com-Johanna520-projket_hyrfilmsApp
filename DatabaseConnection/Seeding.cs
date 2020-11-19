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
                    new Customer { Email = "kalleabdul@hotmail.com", FirstName = "Kalle", LastName = "Abdul", Birthday = "1988-04-01"}


                });

                var Movies = new List<Movie>();
                var lines = File.ReadAllLines(@""); // vet ej hur jag skriver rätt patch... 
                                                    //(hela path = C:\Users\Johan\source\repos\projektDatalagring\DatabaseConnection\SeedData\MovieGenre.csv )



                ctx.AddRange(new List<Rental>
                {
                    new Rental { RentalDate = "2020-10-19"},
                    new Rental { RentalDate = "2020-10-31"},
                    new Rental { RentalDate = "2020-10-31"},
                    new Rental { RentalDate = "2020-11-01"},
                    new Rental { RentalDate = "2020-11-10"}
                }) ;

                ctx.AddRange(new List<Genre>
                { 

                });



                ctx.AddRange(new List<LeadActor>
                {

                });

                ctx.SaveChanges();
            }
        
        }
    }
}
