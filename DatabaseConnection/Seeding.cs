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

                ctx.AddRange(new List<Movie>
                {
                    new Movie {Title = "The Dark Knight",                                   Year = 2008, ImbdRating = 9.0},
                    new Movie {Title = "The Lord of the Rings: The Return of the Kingt",    Year = 2003, ImbdRating = 8.9},
                    new Movie {Title = "Inception",                                         Year = 2010, ImbdRating = 8.8},
                    new Movie {Title = "Matrix",                                            Year = 2008, ImbdRating = 9.0},
                    new Movie {Title = "Star Warst",                                        Year = 1977, ImbdRating = 8.6},
                    new Movie {Title = "The Lion King",                                     Year = 1994, ImbdRating = 8.5},
                    new Movie {Title = "WALL-E",                                            Year = 2008, ImbdRating = 8.4},
                    new Movie {Title = "Toy Story",                                         Year = 2008, ImbdRating = 9.0},
                    new Movie {Title = "Up",                                                Year = 2009, ImbdRating = 8.2},
                    new Movie {Title = "Finding Nemo",                                      Year = 2003, ImbdRating = 8.1},
                    new Movie {Title = "Se7en",                                             Year = 1995, ImbdRating = 8.6},
                    new Movie {Title = "The Silence of the Lambs",                          Year = 1991, ImbdRating = 8.6},
                    new Movie {Title = "Joker",                                             Year = 2019, ImbdRating = 8.5},
                    new Movie {Title = "Shutter Island",                                    Year = 2010, ImbdRating = 8.2},
                    new Movie {Title = "Gone Girl",                                         Year = 2014, ImbdRating = 8.1},
                    new Movie {Title = "Forest Gump",                                       Year = 1994, ImbdRating = 8.8},
                    new Movie {Title = "La La Land",                                        Year = 2016, ImbdRating = 8.0},
                    new Movie {Title = "Casablanca",                                        Year = 1942, ImbdRating = 8.5},
                    new Movie {Title = "Slumdog Millionare",                                Year = 2008, ImbdRating = 8.0},
                    new Movie {Title = "La vita è bella",                                   Year = 1997, ImbdRating = 8.6},
                
                });



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
                    new LeadActor {FirstName ="Christian",      LastName ="Bale", Movies = },   //The Dark Knight
                    new LeadActor {FirstName ="Heath",          LastName ="Ledger"},
                    new LeadActor {FirstName ="Elijah",         LastName ="Wood"},              //The Lord of the Ring
                    new LeadActor {FirstName ="Ian",            LastName ="McKellen"},
                    new LeadActor {FirstName ="Leonardo ",      LastName ="DiCaprio"},          //Inception
                    new LeadActor {FirstName ="Joseph ",        LastName ="Gordon-Levitt"},
                    new LeadActor {FirstName ="Keanu",          LastName ="Reeves"},            //Matrix
                    new LeadActor {FirstName ="Laurence",       LastName ="Fishburne"},
                    new LeadActor {FirstName ="Harrison ",      LastName ="Ford"},              //Star Wars
                    new LeadActor {FirstName ="Carrie ",        LastName ="Fisher"},
                    new LeadActor {FirstName ="Morgan",         LastName ="Freeman"},           //se7en
                    new LeadActor {FirstName ="Brad",           LastName ="Pitt"},
                    new LeadActor {FirstName ="Jodie",          LastName ="Foster"},            //The Silence of the Lambs
                    new LeadActor {FirstName ="Anthony",        LastName ="Hopkins"},
                    new LeadActor {FirstName ="Joaquin",        LastName ="Phoenix"},           //Joker
                    new LeadActor {FirstName ="Robert",         LastName ="De Niro"},
                    new LeadActor {FirstName ="Leonardo",       LastName ="DiCaprio"},          //Shutter Island !!LEO IGEN??
                    new LeadActor {FirstName ="Emily",          LastName ="Mortimer"},
                    new LeadActor {FirstName ="Ben",            LastName ="Affleck"},           //Gone Girl
                    new LeadActor {FirstName ="Rosamund ",      LastName ="Pike"},
                    new LeadActor {FirstName ="Tom",            LastName ="Hanks"},             //Forest Gump
                    new LeadActor {FirstName ="Robin",          LastName ="Wright"},
                    new LeadActor {FirstName ="Ryan ",          LastName ="Gosling"},           //La La Land
                    new LeadActor {FirstName ="Emma",           LastName ="Stone"},
                    new LeadActor {FirstName ="Humphrey",       LastName ="Bogart"},            //Casablanca
                    new LeadActor {FirstName ="Ingrid",         LastName ="Bergman"},
                    new LeadActor {FirstName ="Dev",            LastName ="Patel"},             //Slumdog Millionare
                    new LeadActor {FirstName ="Freida",         LastName ="Pinto"},
                    new LeadActor {FirstName ="Roberto",        LastName ="Benigni"},            //La vita è bella
                    new LeadActor {FirstName ="Nicoletta",      LastName ="Braschi"},
                }); 

                ctx.SaveChanges();
            }
        
        }
    }
}
