using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace DatabaseConnection
{
    public class Seeding
    {
        static void Main()
        {
            using (var ctx = new Context())
            {
                ctx.RemoveRange(ctx.Customers);
                ctx.RemoveRange(ctx.Genres);
                ctx.RemoveRange(ctx.LeadActors);
                ctx.RemoveRange(ctx.Movies);
                ctx.RemoveRange(ctx.Rentals);


                List<Customer> Customers = new List<Customer>
            
                 {
                    new Customer { Email = "kalleabdul@hotmail.com",        FirstName = "Kalle",        LastName = "Abdul",         Birthday = "1988-04-01"},
                    new Customer { Email = "kevab@gmail.com",               FirstName = "Kevin",        LastName = "Aban",          Birthday = "1991-12-29"},
                    new Customer { Email = "christine.lofberg@telia.com",   FirstName = "Christine",    LastName = "Löfberg",       Birthday = "1960-05-14"},
                    new Customer { Email = "emelie.s.smith@gmail.com",      FirstName = "Emelie",       LastName = "Smith",         Birthday = "1997-01-23"},
                    new Customer { Email = "jocke_starfighter@yahoo.com",   FirstName = "Joakim",       LastName = "Stjernfeldt",   Birthday = "1977-08-22"}

                };
                ctx.AddRange(Customers);

                List<Genre> Genres = new List<Genre>
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


                List<LeadActor> LeadActors = new List<LeadActor>
                { 
                    new LeadActor {FirstName ="Christian",      LastName ="Bale"},              
                    new LeadActor {FirstName ="Heath",          LastName ="Ledger"},            
                    new LeadActor {FirstName ="Elijah",         LastName ="Wood"},              
                    new LeadActor {FirstName ="Ian",            LastName ="McKellen"},          
                    new LeadActor {FirstName ="Leonardo ",      LastName ="DiCaprio"},                         
                    new LeadActor {FirstName ="Joseph ",        LastName ="Gordon-Levitt"},        
                    new LeadActor {FirstName ="Keanu",          LastName ="Reeves"},                         
                    new LeadActor {FirstName ="Laurence",       LastName ="Fishburne"},            
                    new LeadActor {FirstName ="Harrison ",      LastName ="Ford"},                           
                    new LeadActor {FirstName ="Carrie ",        LastName ="Fisher"},               
                    new LeadActor {FirstName ="Morgan",         LastName ="Freeman"},                       
                    new LeadActor {FirstName ="Brad",           LastName ="Pitt"},                  
                    new LeadActor {FirstName ="Jodie",          LastName ="Foster"},                                           
                    new LeadActor {FirstName ="Anthony",        LastName ="Hopkins"},               
                    new LeadActor {FirstName ="Joaquin",        LastName ="Phoenix"},                       
                    new LeadActor {FirstName ="Robert",         LastName ="De Niro"},               
                    new LeadActor {FirstName ="Emily",          LastName ="Mortimer"},                                   
                    new LeadActor {FirstName ="Ben",            LastName ="Affleck"},                           
                    new LeadActor {FirstName ="Rosamund ",      LastName ="Pike"},                  
                    new LeadActor {FirstName ="Tom",            LastName ="Hanks"},                              
                    new LeadActor {FirstName ="Robin",          LastName ="Wright"},                
                    new LeadActor {FirstName ="Ryan ",          LastName ="Gosling"},                           
                    new LeadActor {FirstName ="Emma",           LastName ="Stone"},                 
                    new LeadActor {FirstName ="Humphrey",       LastName ="Bogart"},                            
                    new LeadActor {FirstName ="Ingrid",         LastName ="Bergman"},               
                    new LeadActor {FirstName ="Dev",            LastName ="Patel"},                                     
                    new LeadActor {FirstName ="Freida",         LastName ="Pinto"},                 
                    new LeadActor {FirstName ="Roberto",        LastName ="Benigni"},                                
                    new LeadActor {FirstName ="Nicoletta",      LastName ="Braschi"},               
                    new LeadActor {FirstName ="Tim",            LastName ="Robbins"},                                             
                    new LeadActor {FirstName ="Liam",           LastName ="Nelson"},                                        
                    new LeadActor {FirstName ="Ralph",          LastName ="Finess"},                
                    new LeadActor {FirstName ="John",           LastName ="Travolta"},                               
                    new LeadActor {FirstName ="Uma",            LastName ="Thurman"},           
                    new LeadActor {FirstName ="Clint",          LastName ="Eastwood"},                                                
                    new LeadActor {FirstName ="Eli",            LastName ="Wallach"},           
                    new LeadActor {FirstName ="Edward",         LastName ="Norton"},                                   
                    new LeadActor {FirstName ="Matt",           LastName ="Damon"},                     
                    new LeadActor {FirstName ="Ray",            LastName ="Liotta"},                        
                    new LeadActor {FirstName = "Ellen",         LastName = "DeGeneres"},           
                    new LeadActor {FirstName = "Albert",        LastName ="Brooks" },              
                    new LeadActor {FirstName = "Matthew",       LastName ="Broderick"},                  
                    new LeadActor {FirstName = "Jeremy",        LastName ="Irons" },             
                    new LeadActor {FirstName = "Ben",           LastName ="Burtt" },                           
                    new LeadActor {FirstName = "Elissa",        LastName ="Knight" },              
                    new LeadActor {FirstName = "Tim",           LastName ="Allen" },                        
                    new LeadActor {FirstName = "Edward",        LastName ="Asner" },        
                    new LeadActor {FirstName = "Jordan",        LastName ="Nagai" }     

                };
                ctx.AddRange(LeadActors);

                List<Movie> Movies = new List<Movie>
                {
                    new Movie { Title = "The Dark Knight",                                LeadActors = new List<LeadActor>{LeadActors[0],  LeadActors[1]},   Year = 2008,   Genres = new List<Genre>{Genres[0], Genres[1], Genres[3], Genres[11]},                  ImbdRating = 9.0, ImageURL = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "The Lord of the Rings: The Return of the King",  LeadActors = new List<LeadActor>{LeadActors[2],  LeadActors[3]},   Year = 2003,   Genres = new List<Genre>{Genres[1], Genres[6], Genres[3], Genres[5]},                   ImbdRating = 8.9, ImageURL = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Inception",                                      LeadActors = new List<LeadActor>{LeadActors[4],  LeadActors[5]},   Year = 2010,   Genres = new List<Genre>{Genres[1], Genres[6], Genres[7], Genres[11]},                  ImbdRating = 8.8, ImageURL = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                    new Movie { Title = "The Matrix",                                     LeadActors = new List<LeadActor>{LeadActors[6],  LeadActors[7]},   Year = 2008,   Genres = new List<Genre>{Genres[1], Genres[7]},                                         ImbdRating = 8.7, ImageURL = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Star Wars: Episode IV - A new Hope",             LeadActors = new List<LeadActor>{LeadActors[8],  LeadActors[9]},   Year = 1977,   Genres = new List<Genre>{Genres[1], Genres[6], Genres[5], Genres[7]},                   ImbdRating = 8.6, ImageURL = "https://m.media-amazon.com/images/M/MV5BNzVlY2MwMjktM2E4OS00Y2Y3LWE3ZjctYzhkZGM3YzA1ZWM2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "The Lion King",                                  LeadActors = new List<LeadActor>{LeadActors[42], LeadActors[41]},  Year = 1994,   Genres = new List<Genre>{Genres[9], Genres[6], Genres[3], Genres[8], Genres[15]},       ImbdRating = 8.5, ImageURL = "https://m.media-amazon.com/images/M/MV5BNzVmNzQ2ZmYtMmUzNy00MzhjLTg4ODUtMTQ0MjMzYTdkMDg5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY268_CR5,0,182,268_AL_.jpg" },
                    new Movie { Title = "WALL-E",                                         LeadActors = new List<LeadActor>{LeadActors[44], LeadActors[43]},  Year = 2008,   Genres = new List<Genre>{Genres[9], Genres[6], Genres[8], Genres[7]},                   ImbdRating = 8.4, ImageURL = "https://m.media-amazon.com/images/M/MV5BMjExMTg5OTU0NF5BMl5BanBnXkFtZTcwMjMxMzMzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Toy Story",                                      LeadActors = new List<LeadActor>{LeadActors[19], LeadActors[45]},  Year = 1995,   Genres = new List<Genre>{Genres[9], Genres[6], Genres[10], Genres[8], Genres[5]},       ImbdRating = 9.0, ImageURL = "https://m.media-amazon.com/images/M/MV5BMDU2ZWJlMjktMTRhMy00ZTA5LWEzNDgtYmNmZTEwZTViZWJkXkEyXkFqcGdeQXVyNDQ2OTk4MzI@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Up",                                             LeadActors = new List<LeadActor>{LeadActors[47], LeadActors[46]},  Year = 2009,   Genres = new List<Genre>{Genres[9], Genres[6], Genres[10], Genres[8]},                  ImbdRating = 8.2, ImageURL = "https://m.media-amazon.com/images/M/MV5BMTk3NDE2NzI4NF5BMl5BanBnXkFtZTgwNzE1MzEyMTE@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Finding Nemo",                                   LeadActors = new List<LeadActor>{LeadActors[39], LeadActors[40]},  Year = 2003,   Genres = new List<Genre>{Genres[9], Genres[6], Genres[10], Genres[8]},                  ImbdRating = 8.1, ImageURL = "https://m.media-amazon.com/images/M/MV5BZTAzNWZlNmUtZDEzYi00ZjA5LWIwYjEtZGM1NWE1MjE4YWRhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Se7en",                                          LeadActors = new List<LeadActor>{LeadActors[11], LeadActors[10]},  Year = 1995,   Genres = new List<Genre>{Genres[0], Genres[3], Genres[12], Genres[11]},                 ImbdRating = 8.6, ImageURL = "https://m.media-amazon.com/images/M/MV5BOTUwODM5MTctZjczMi00OTk4LTg3NWUtNmVhMTAzNTNjYjcyXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "The Silence of the Lambs",                       LeadActors = new List<LeadActor>{LeadActors[12], LeadActors[13]},  Year = 1991,   Genres = new List<Genre>{Genres[0], Genres[3], Genres[11]},                             ImbdRating = 8.6, ImageURL = "https://m.media-amazon.com/images/M/MV5BNjNhZTk0ZmEtNjJhMi00YzFlLWE1MmEtYzM1M2ZmMGMwMTU4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Joker",                                          LeadActors = new List<LeadActor>{LeadActors[14], LeadActors[15]},  Year = 2019,   Genres = new List<Genre>{Genres[0], Genres[3], Genres[11]},                             ImbdRating = 8.5, ImageURL = "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Shutter Island",                                 LeadActors = new List<LeadActor>{LeadActors[4],  LeadActors[16]},  Year = 2010,   Genres = new List<Genre>{Genres[12], Genres[11]},                                       ImbdRating = 8.2, ImageURL = "https://m.media-amazon.com/images/M/MV5BYzhiNDkyNzktNTZmYS00ZTBkLTk2MDAtM2U0YjU1MzgxZjgzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Gone Girl",                                      LeadActors = new List<LeadActor>{LeadActors[18], LeadActors[17]},  Year = 2014,   Genres = new List<Genre>{Genres[3], Genres[12], Genres[11]},                            ImbdRating = 8.1, ImageURL = "https://m.media-amazon.com/images/M/MV5BMTk0MDQ3MzAzOV5BMl5BanBnXkFtZTgwNzU1NzE3MjE@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Forrest Gump",                                   LeadActors = new List<LeadActor>{LeadActors[20], LeadActors[19]},  Year = 1994,   Genres = new List<Genre>{Genres[3], Genres[13]},                                        ImbdRating = 8.8, ImageURL = "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY268_CR1,0,182,268_AL_.jpg" },
                    new Movie { Title = "La La Land",                                     LeadActors = new List<LeadActor>{LeadActors[22], LeadActors[21]},  Year = 2016,   Genres = new List<Genre>{Genres[10], Genres[3], Genres[14], Genres[15], Genres[13]},    ImbdRating = 8.0, ImageURL = "https://m.media-amazon.com/images/M/MV5BMzUzNDM2NzM2MV5BMl5BanBnXkFtZTgwNTM3NTg4OTE@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Casablanca",                                     LeadActors = new List<LeadActor>{LeadActors[24], LeadActors[23]},  Year = 1942,   Genres = new List<Genre>{Genres[3], Genres[13], Genres[16]},                            ImbdRating = 8.5, ImageURL = "https://m.media-amazon.com/images/M/MV5BY2IzZGY2YmEtYzljNS00NTM5LTgwMzUtMzM1NjQ4NGI0OTk0XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Slumdog Millionare",                             LeadActors = new List<LeadActor>{LeadActors[26], LeadActors[25]},  Year = 2008,   Genres = new List<Genre>{Genres[3], Genres[13]},                                        ImbdRating = 8.0, ImageURL = "https://m.media-amazon.com/images/M/MV5BZmNjZWI3NzktYWI1Mi00OTAyLWJkNTYtMzUwYTFlZDA0Y2UwXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "La vita è bella",                                LeadActors = new List<LeadActor>{LeadActors[27], LeadActors[28]},  Year = 1997,   Genres = new List<Genre>{Genres[10], Genres[3], Genres[13], Genres[16]},                ImbdRating = 8.6, ImageURL = "https://m.media-amazon.com/images/M/MV5BYmJmM2Q4NmMtYThmNC00ZjRlLWEyZmItZTIwOTBlZDQ3NTQ1XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "The Shawshank Redemption",                       LeadActors = new List<LeadActor>{LeadActors[29], LeadActors[10]},  Year = 1994,   Genres = new List<Genre>{Genres[3]},                                                    ImbdRating = 9.3, ImageURL = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Schindler's List",                               LeadActors = new List<LeadActor>{LeadActors[30], LeadActors[31]},  Year = 1993,   Genres = new List<Genre>{Genres[2], Genres[3]},                                         ImbdRating = 8.9, ImageURL = "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Pulp Fiction",                                   LeadActors = new List<LeadActor>{LeadActors[32], LeadActors[33]},  Year = 1994,   Genres = new List<Genre>{Genres[0], Genres[3]},                                         ImbdRating = 8.9, ImageURL = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR1,0,182,268_AL_.jpg" },
                    new Movie { Title = "The Good, the Bad and the Ugly",                 LeadActors = new List<LeadActor>{LeadActors[35], LeadActors[34]},  Year = 1966,   Genres = new List<Genre>{Genres[4]},                                                    ImbdRating = 8.8, ImageURL = "https://m.media-amazon.com/images/M/MV5BOTQ5NDI3MTI4MF5BMl5BanBnXkFtZTgwNDQ4ODE5MDE@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Fight Club",                                     LeadActors = new List<LeadActor>{LeadActors[11], LeadActors[36]},  Year = 1999,   Genres = new List<Genre>{Genres[3]},                                                    ImbdRating = 8.8, ImageURL = "https://m.media-amazon.com/images/M/MV5BMmEzNTkxYjQtZTc0MC00YTVjLTg5ZTEtZWMwOWVlYzY0NWIwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX182_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Saving Private Ryan",                            LeadActors = new List<LeadActor>{LeadActors[19], LeadActors[37]},  Year = 1998,   Genres = new List<Genre>{Genres[3], Genres[16] },                                       ImbdRating = 8.6, ImageURL = "https://m.media-amazon.com/images/M/MV5BZjhkMDM4MWItZTVjOC00ZDRhLThmYTAtM2I5NzBmNmNlMzI1XkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_UY268_CR0,0,182,268_AL_.jpg" },
                    new Movie { Title = "Goodfellas",                                     LeadActors = new List<LeadActor>{LeadActors[15], LeadActors[38]},  Year = 1990,   Genres = new List<Genre>{Genres[2], Genres[0], Genres[3]},                              ImbdRating = 8.7, ImageURL = "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UX182_CR0,0,182,268_AL_.jpg" }

                };
                ctx.AddRange(Movies);



                List<Rental> Rentals = new List<Rental>
                { 
                    new Rental {RentalDate = DateTime.Parse("2020-10-05 10:05:03"), Customer = Customers[0], Movie = Movies[10]},
                    new Rental {RentalDate = DateTime.Parse("2020-10-31 17:28:21"), Customer = Customers[1], Movie = Movies[7]},
                    new Rental {RentalDate = DateTime.Parse("2020-10-31 17:28:21"), Customer = Customers[2], Movie = Movies[2]},
                    new Rental {RentalDate = DateTime.Parse("2020-11-01 15:48:52"), Customer = Customers[3], Movie = Movies[15]},
                    new Rental {RentalDate = DateTime.Parse("2020-11-10 16:02:22"), Customer = Customers[4], Movie = Movies[20]}
                };
                ctx.AddRange(Rentals);  
                       
               
                ctx.SaveChanges();
            }
        }
    }
}

