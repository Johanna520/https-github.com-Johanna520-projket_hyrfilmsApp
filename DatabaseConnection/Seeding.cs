
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

                var Customers = new List<Customer>
            
                 {
                    new Customer { Email = "kalleabdul@hotmail.com",        FirstName = "Kalle",        LastName = "Abdul",         Birthday = "1988-04-01"},
                    new Customer { Email = "kevab@gmail.com",               FirstName = "Kevin",        LastName = "Aban",          Birthday = "1991-12-29"},
                    new Customer { Email = "christine.lofberg@telia.com",   FirstName = "Christine",    LastName = "Löfberg",       Birthday = "1960-05-14"},
                    new Customer { Email = "emelie.s.smith@gmail.com",      FirstName = "Emelie",       LastName = "Smith",         Birthday = "1997-01-23"},
                    new Customer { Email = "jocke_starfighter@yahoo.com",   FirstName = "Joakim",       LastName = "Stjernfeldt",   Birthday = "1977-08-22"}

                };
                ctx.AddRange(Customers);



                var Movies = new List<Movie>
                {
                    new Movie { Title = "The Dark Knight",                                  Year = 2008, ImbdRating = 9.0}, 
                    new Movie { Title = "The Lord of the Rings: The Return of the King",    Year = 2003, ImbdRating = 8.9},
                    new Movie { Title = "Inception",                                        Year = 2010, ImbdRating = 8.8},
                    new Movie { Title = "The Matrix",                                       Year = 2008, ImbdRating = 8.7},
                    new Movie { Title = "Star Wars: Episode IV - A new Hope",               Year = 1977, ImbdRating = 8.6},
                    new Movie { Title = "The Lion King",                                    Year = 1994, ImbdRating = 8.5},
                    new Movie { Title = "WALL-E",                                           Year = 2008, ImbdRating = 8.4},
                    new Movie { Title = "Toy Story",                                        Year = 2008, ImbdRating = 9.0},
                    new Movie { Title = "Up",                                               Year = 2009, ImbdRating = 8.2},
                    new Movie { Title = "Finding Nemo",                                     Year = 2003, ImbdRating = 8.1},
                    new Movie { Title = "Se7en",                                            Year = 1995, ImbdRating = 8.6},
                    new Movie { Title = "The Silence of the Lambs",                         Year = 1991, ImbdRating = 8.6},
                    new Movie { Title = "Joker",                                            Year = 2019, ImbdRating = 8.5},
                    new Movie { Title = "Shutter Island",                                   Year = 2010, ImbdRating = 8.2},
                    new Movie { Title = "Gone Girl",                                        Year = 2014, ImbdRating = 8.1},
                    new Movie { Title = "Forrest Gump",                                     Year = 1994, ImbdRating = 8.8},
                    new Movie { Title = "La La Land",                                       Year = 2016, ImbdRating = 8.0},
                    new Movie { Title = "Casablanca",                                       Year = 1942, ImbdRating = 8.5},
                    new Movie { Title = "Slumdog Millionare",                               Year = 2008, ImbdRating = 8.0},
                    new Movie { Title = "La vita è bella",                                  Year = 1997, ImbdRating = 8.6},
                    new Movie { Title = "The Shawshank Redemption",                         Year = 1994, ImbdRating = 9.3},
                    new Movie { Title = "Schindler's List",                                 Year = 1993, ImbdRating = 8.9},
                    new Movie { Title = "Pulp Fiction",                                     Year = 1994, ImbdRating = 8.9},
                    new Movie { Title = "The Good, the Bad and the Ugly",                   Year = 1966, ImbdRating = 8.8},
                    new Movie { Title = "Fight Club",                                       Year = 1999, ImbdRating = 8.8},
                    new Movie { Title = "Saving Private Ryan",                              Year = 1998, ImbdRating = 8.6},
                    new Movie { Title = "Goodfellas",                                       Year = 1990, ImbdRating = 8.7}
                };
                ctx.AddRange(Movies);


                var Rentals = new List<Rental>
                ctx.AddRange(new List<Rental>
                {
                    new Rental {RentalDate = "2020-10-19", Customer = Customers[0], Movie = Movies[10]},
                    new Rental {RentalDate = "2020-10-31", Customer = Customers[1], Movie = Movies[7]},
                    new Rental {RentalDate = "2020-10-31", Customer = Customers[2], Movie = Movies[2]},
                    new Rental {RentalDate = "2020-11-01", Customer = Customers[3], Movie = Movies[15]},
                    new Rental {RentalDate = "2020-11-10", Customer = Customers[4], Movie = Movies[20]}
                };
                ctx.AddRange(Rentals);
                
                var Genres = new List<Genre> 
                { 
                    new Genre { GenreName = "Crime" },
                    new Genre { GenreName = "Action" },
                    new Genre { GenreName = "Biography" },
                    new Genre { GenreName = "Drama" },
                    new Genre { GenreName = "Western" },
                    new Genre { GenreName = "Fantasy" },
                    new Genre { GenreName = "Adventure" },
                    new Genre { GenreName = "Sci-Fi" },
                    new Genre { GenreName = "Family" },
                    new Genre { GenreName = "Animation" },
                    new Genre { GenreName = "Comedy" },
                    new Genre { GenreName = "Thriller" },
                    new Genre { GenreName = "Mystery" },
                    new Genre { GenreName = "Romance" },
                    new Genre { GenreName = "Music" },
                    new Genre { GenreName = "Musical" },
                    new Genre { GenreName = "War" }
                };
                ctx.AddRange(Genres);

               

                var LeadActors = new List<LeadActor> 

                {
                    new LeadActor {FirstName ="Christian",      LastName ="Bale"},              //The Dark Knight
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
                    new LeadActor {FirstName ="Roberto",        LastName ="Benigni"},           //La vita è bella
                    new LeadActor {FirstName ="Nicoletta",      LastName ="Braschi"},
                    new LeadActor {FirstName ="Tim",            LastName ="Robbins"},           //The Shawshank Redemption 
                    new LeadActor {FirstName ="Morgan",         LastName ="Freeman"},
                    new LeadActor {FirstName ="Liam",           LastName ="Neeson"},            //Schindler's List      
                    new LeadActor {FirstName ="Ralph",          LastName ="Finess"},
                    new LeadActor {FirstName ="John",           LastName ="Travolta"},          //Pulp Fiction   
                    new LeadActor {FirstName ="Uma",            LastName ="Thurman"},
                    new LeadActor {FirstName ="Clint",          LastName ="Eastwood"},          //The Good, the Bad and the Ugly  
                    new LeadActor {FirstName ="Eli",            LastName ="Wallach"},
                    new LeadActor {FirstName ="Brad",           LastName ="Pitt"},              //Flight Club       
                    new LeadActor {FirstName ="Edward",         LastName ="Norton"},
                    new LeadActor {FirstName ="Tom",            LastName ="Hanks"},             //Saving Private Ryan
                    new LeadActor {FirstName ="Matt",           LastName ="Damon"},
                    new LeadActor {FirstName ="Robert",         LastName ="De Niro"},           //Goodfellas
                    new LeadActor {FirstName ="Ray",            LastName ="Liotta"}
                };
                ctx.AddRange(LeadActors);

                ctx.SaveChanges();
            }
  
        }
    }
}
