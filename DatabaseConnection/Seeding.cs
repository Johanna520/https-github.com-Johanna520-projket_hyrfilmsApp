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

                ctx.AddRange(new List<Rental>
                {

                });

                ctx.SaveChanges();
            }
        
        }
    }
}
