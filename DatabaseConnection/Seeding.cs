
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

                List<Customer> Customers = new List<Customer>
            
                 {
                    new Customer { Email = "kalleabdul@hotmail.com",        FirstName = "Kalle",        LastName = "Abdul",         Birthday = "1988-04-01"},
                    new Customer { Email = "kevab@gmail.com",               FirstName = "Kevin",        LastName = "Aban",          Birthday = "1991-12-29"},
                    new Customer { Email = "christine.lofberg@telia.com",   FirstName = "Christine",    LastName = "Löfberg",       Birthday = "1960-05-14"},
                    new Customer { Email = "emelie.s.smith@gmail.com",      FirstName = "Emelie",       LastName = "Smith",         Birthday = "1997-01-23"},
                    new Customer { Email = "jocke_starfighter@yahoo.com",   FirstName = "Joakim",       LastName = "Stjernfeldt",   Birthday = "1977-08-22"}

                };
                ctx.AddRange(Customers);

                List<LeadActor> LeadActors = new List<LeadActor>
                { 
                    new LeadActor {FirstName ="Christian",      LastName ="Bale"},              //The Dark Knight
                    new LeadActor {FirstName ="Heath",          LastName ="Ledger"},            //
                    new LeadActor {FirstName ="Elijah",         LastName ="Wood"},              //The Lord of the Ring
                    new LeadActor {FirstName ="Ian",            LastName ="McKellen"},          //
                    new LeadActor {FirstName ="Leonardo ",      LastName ="DiCaprio"},          //5 //Inception
                    new LeadActor {FirstName ="Joseph ",        LastName ="Gordon-Levitt"},     //6
                    new LeadActor {FirstName ="Keanu",          LastName ="Reeves"},            //7 //Matrix
                    new LeadActor {FirstName ="Laurence",       LastName ="Fishburne"},         //8
                    new LeadActor {FirstName ="Harrison ",      LastName ="Ford"},              //9 Star Wars
                    new LeadActor {FirstName ="Carrie ",        LastName ="Fisher"},            //10
                    new LeadActor {FirstName ="Morgan",         LastName ="Freeman"},           //11 //se7en
                    new LeadActor {FirstName ="Brad",           LastName ="Pitt"},              //12
                    new LeadActor {FirstName ="Jodie",          LastName ="Foster"},            //13 //The Silence of the Lambs
                    new LeadActor {FirstName ="Anthony",        LastName ="Hopkins"},           //14
                    new LeadActor {FirstName ="Joaquin",        LastName ="Phoenix"},           //15 //Joker
                    new LeadActor {FirstName ="Robert",         LastName ="De Niro"},           //16
                    new LeadActor {FirstName ="Emily",          LastName ="Mortimer"},          //5 + 17//Shutter Island 
                    new LeadActor {FirstName ="Ben",            LastName ="Affleck"},           //18 //Gone Girl
                    new LeadActor {FirstName ="Rosamund ",      LastName ="Pike"},              //19
                    new LeadActor {FirstName ="Tom",            LastName ="Hanks"},             //20//Forest Gump
                    new LeadActor {FirstName ="Robin",          LastName ="Wright"},            //21
                    new LeadActor {FirstName ="Ryan ",          LastName ="Gosling"},           //22//La La Land
                    new LeadActor {FirstName ="Emma",           LastName ="Stone"},             //23
                    new LeadActor {FirstName ="Humphrey",       LastName ="Bogart"},            //24//Casablanca
                    new LeadActor {FirstName ="Ingrid",         LastName ="Bergman"},           //25
                    new LeadActor {FirstName ="Dev",            LastName ="Patel"},             //26//Slumdog Millionare
                    new LeadActor {FirstName ="Freida",         LastName ="Pinto"},             //27
                    new LeadActor {FirstName ="Roberto",        LastName ="Benigni"},           //28//La vita è bella
                    new LeadActor {FirstName ="Nicoletta",      LastName ="Braschi"},           //29
                    new LeadActor {FirstName ="Tim",            LastName ="Robbins"},           //30+11//The Shawshank Redemption 
                    new LeadActor {FirstName ="Liam",           LastName ="Nelson"},            //31//Schindler's List      
                    new LeadActor {FirstName ="Ralph",          LastName ="Finess"},            //32
                    new LeadActor {FirstName ="John",           LastName ="Travolta"},          //33//Pulp Fiction   
                    new LeadActor {FirstName ="Uma",            LastName ="Thurman"},           //34
                    new LeadActor {FirstName ="Clint",          LastName ="Eastwood"},          //35//The Good, the Bad and the Ugly  
                    new LeadActor {FirstName ="Eli",            LastName ="Wallach"},           //36
                    new LeadActor {FirstName ="Edward",         LastName ="Norton"},            //12+37 //Flight Club  
                    new LeadActor {FirstName ="Matt",           LastName ="Damon"},             //20+38 //Saving Private Ryan
                    new LeadActor {FirstName ="Ray",            LastName ="Liotta"},            //16+39 //Goodfellas
                    new LeadActor {FirstName = "Ellen",         LastName = "DeGeneres"},       //40, Finding Nemo
                    new LeadActor {FirstName = "Albert",        LastName ="Brooks" },            //41
                    new LeadActor {FirstName = "Matthew",       LastName ="Broderick"},        //42 Lion King
                    new LeadActor {FirstName = "Jeremy",        LastName ="Irons" },             //43
                    new LeadActor {FirstName = "Ben",           LastName ="Burtt" },                //44 Wall-E
                    new LeadActor {FirstName = "Elissa",        LastName ="Knight" },              //45
                    new LeadActor {FirstName = "Tim",           LastName ="Allen" },           //46, ToyStory
                    new LeadActor {FirstName = "Edward",       LastName ="Asner" },        //47Up
                    new LeadActor {FirstName = "Jordan",       LastName ="Nagai" }     //48

                };
                ctx.AddRange(LeadActors);

                List<Movie> Movies = new List<Movie>
                {
                    new Movie { Title = "The Dark Knight",                                 LeadActors = new List<LeadActor>{LeadActors[0],  LeadActors[1]},     Year = 2008, ImbdRating = 9.0}, 
                    new Movie { Title = "The Lord of the Rings: The Return of the King",   LeadActors = new List<LeadActor>{LeadActors[3],  LeadActors[4]},     Year = 2003, ImbdRating = 8.9},
                    new Movie { Title = "Inception",                                       LeadActors = new List<LeadActor>{LeadActors[5],  LeadActors[6]},     Year = 2010, ImbdRating = 8.8},
                    new Movie { Title = "The Matrix",                                      LeadActors = new List<LeadActor>{LeadActors[7],  LeadActors[8]},     Year = 2008, ImbdRating = 8.7},
                    new Movie { Title = "Star Wars: Episode IV - A new Hope",              LeadActors = new List<LeadActor>{LeadActors[9],  LeadActors[10]},    Year = 1977, ImbdRating = 8.6},
                    new Movie { Title = "The Lion King",                                   LeadActors = new List<LeadActor>{LeadActors[42], LeadActors[43]},   Year = 1994, ImbdRating = 8.5},
                    new Movie { Title = "WALL-E",                                          LeadActors = new List<LeadActor>{LeadActors[44], LeadActors[45]},   Year = 2008, ImbdRating = 8.4},
                    new Movie { Title = "Toy Story",                                       LeadActors = new List<LeadActor>{LeadActors[20], LeadActors[46]},   Year = 2008, ImbdRating = 9.0},
                    new Movie { Title = "Up",                                              LeadActors = new List<LeadActor>{LeadActors[47], LeadActors[48]},   Year = 2009, ImbdRating = 8.2},
                    new Movie { Title = "Finding Nemo",                                    LeadActors = new List<LeadActor>{LeadActors[40], LeadActors[41]},   Year = 2003, ImbdRating = 8.1},
                    new Movie { Title = "Se7en",                                           LeadActors = new List<LeadActor>{LeadActors[11], LeadActors[12]},   Year = 1995, ImbdRating = 8.6},
                    new Movie { Title = "The Silence of the Lambs",                        LeadActors = new List<LeadActor>{LeadActors[13], LeadActors[14]},   Year = 1991, ImbdRating = 8.6},
                    new Movie { Title = "Joker",                                           LeadActors = new List<LeadActor>{LeadActors[15], LeadActors[16]},   Year = 2019, ImbdRating = 8.5},
                    new Movie { Title = "Shutter Island",                                  LeadActors = new List<LeadActor>{LeadActors[5],  LeadActors[17]},    Year = 2010, ImbdRating = 8.2},
                    new Movie { Title = "Gone Girl",                                       LeadActors = new List<LeadActor>{LeadActors[18], LeadActors[19]},   Year = 2014, ImbdRating = 8.1},
                    new Movie { Title = "Forrest Gump",                                    LeadActors = new List<LeadActor>{LeadActors[20], LeadActors[21]},   Year = 1994, ImbdRating = 8.8},
                    new Movie { Title = "La La Land",                                      LeadActors = new List<LeadActor>{LeadActors[22], LeadActors[23]},   Year = 2016, ImbdRating = 8.0},
                    new Movie { Title = "Casablanca",                                      LeadActors = new List<LeadActor>{LeadActors[24], LeadActors[25]},   Year = 1942, ImbdRating = 8.5},
                    new Movie { Title = "Slumdog Millionare",                              LeadActors = new List<LeadActor>{LeadActors[26], LeadActors[27]},   Year = 2008, ImbdRating = 8.0},
                    new Movie { Title = "La vita è bella",                                 LeadActors = new List<LeadActor>{LeadActors[28], LeadActors[29]},   Year = 1997, ImbdRating = 8.6},
                    new Movie { Title = "The Shawshank Redemption",                        LeadActors = new List<LeadActor>{LeadActors[30], LeadActors[11]},   Year = 1994, ImbdRating = 9.3},
                    new Movie { Title = "Schindler's List",                                LeadActors = new List<LeadActor>{LeadActors[31], LeadActors[32]},   Year = 1993, ImbdRating = 8.9},
                    new Movie { Title = "Pulp Fiction",                                    LeadActors = new List<LeadActor>{LeadActors[33], LeadActors[34]},   Year = 1994, ImbdRating = 8.9},
                    new Movie { Title = "The Good, the Bad and the Ugly",                  LeadActors = new List<LeadActor>{LeadActors[35], LeadActors[36]},   Year = 1966, ImbdRating = 8.8},
                    new Movie { Title = "Fight Club",                                      LeadActors = new List<LeadActor>{LeadActors[12], LeadActors[37]},   Year = 1999, ImbdRating = 8.8},
                    new Movie { Title = "Saving Private Ryan",                             LeadActors = new List<LeadActor>{LeadActors[20], LeadActors[38]},   Year = 1998, ImbdRating = 8.6},
                    new Movie { Title = "Goodfellas",                                      LeadActors = new List<LeadActor>{LeadActors[16], LeadActors[39]},   Year = 1990, ImbdRating = 8.7}
                
                };
                ctx.AddRange(Movies);



                List<Rental> Rentals = new List<Rental>
                { 
                    new Rental {RentalDate = "2020-10-05", Customer = Customers[0], Movie = Movies[10]},
                    new Rental {RentalDate = "2020-10-31", Customer = Customers[1], Movie = Movies[7]},
                    new Rental {RentalDate = "2020-10-31", Customer = Customers[2], Movie = Movies[2]},
                    new Rental {RentalDate = "2020-11-01", Customer = Customers[3], Movie = Movies[15]},
                    new Rental {RentalDate = "2020-11-10", Customer = Customers[4], Movie = Movies[20]}
                };
                ctx.AddRange(Rentals);    
               

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

               

                

                ctx.SaveChanges();
            }
  
        }
    }
}

/*
                 * The Dark Knight: Action, Crime, Drama, Thriller
                 * The Lord of the Rings: The Return of the King: Action, Adventure, Drama, Fantasy
                 * Inception: Action, Adventure, Sci-Fi, Thriller
                 * The Matrix: Action, Sci-Fi
                 * Star Wars: Episode IV - A new Hope: Action, Adventure, Fantasy, Sci-Fi
                 * The Lion King: Animation, Adventure, Drama, Family, Musical
                 * WALL-E: Animation, Adventure, Family, Sci-Fi
                 * Toy Story: Animatiom, Adventure, Comedy, Family, Fantasy
                 * Up: Animation, Adventure, Comedy, Family
                 * Finding Nemo: Animation, Adventure, Comedy, Family
                 * Se7en: Crime, Drama, Mystery, Thriller
                 * The silence of the lambs: Crime, Drama, Thriller
                 * Joker: Crime, Drama, Thriller
                 * Shutter Island: Mystery, Thriller
                 * Gone Girl: Drama, Mystery, Thriller
                 * Forest Gump: Drama, Romance
                 * La la Land: Comedy, Drama, Music, Musical, Romance
                 * Casablanca: Drama, Romance, War
                 * Slumdog Millionare: Drama, Romance
                 * La vita è bella: Comedy, Drama, Romance, War
                 * The Shawshank Redemption: Drama
                 * Schnindler's list: Biography, Drama, History
                 * Pulp Fiction: Crime, Drama
                 * The Good, the Bad and the Ugly: Western
                 * Fight Club: Drama
                 * Saving Private Ryan: Drama, War
                 * Goodfellas: Biography, Crime, Drama
                 */