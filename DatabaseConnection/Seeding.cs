
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
                    new LeadActor {FirstName ="Christian",      LastName ="Bale"},              //0The Dark Knight
                    new LeadActor {FirstName ="Heath",          LastName ="Ledger"},            //1
                    new LeadActor {FirstName ="Elijah",         LastName ="Wood"},              //2The Lord of the Ring
                    new LeadActor {FirstName ="Ian",            LastName ="McKellen"},          //3
                    new LeadActor {FirstName ="Leonardo ",      LastName ="DiCaprio"},          //4 //Inception
                    new LeadActor {FirstName ="Joseph ",        LastName ="Gordon-Levitt"},     //5
                    new LeadActor {FirstName ="Keanu",          LastName ="Reeves"},            //6 //Matrix
                    new LeadActor {FirstName ="Laurence",       LastName ="Fishburne"},         //7
                    new LeadActor {FirstName ="Harrison ",      LastName ="Ford"},              //8 Star Wars
                    new LeadActor {FirstName ="Carrie ",        LastName ="Fisher"},            //9
                    new LeadActor {FirstName ="Morgan",         LastName ="Freeman"},           //10 //se7en
                    new LeadActor {FirstName ="Brad",           LastName ="Pitt"},              //11
                    new LeadActor {FirstName ="Jodie",          LastName ="Foster"},            //12 //The Silence of the Lambs
                    new LeadActor {FirstName ="Anthony",        LastName ="Hopkins"},           //13
                    new LeadActor {FirstName ="Joaquin",        LastName ="Phoenix"},           //14 //Joker
                    new LeadActor {FirstName ="Robert",         LastName ="De Niro"},           //15
                    new LeadActor {FirstName ="Emily",          LastName ="Mortimer"},          //4 + 16//Shutter Island 
                    new LeadActor {FirstName ="Ben",            LastName ="Affleck"},           //17 //Gone Girl
                    new LeadActor {FirstName ="Rosamund ",      LastName ="Pike"},              //18
                    new LeadActor {FirstName ="Tom",            LastName ="Hanks"},             //19//Forest Gump
                    new LeadActor {FirstName ="Robin",          LastName ="Wright"},            //20
                    new LeadActor {FirstName ="Ryan ",          LastName ="Gosling"},           //21//La La Land
                    new LeadActor {FirstName ="Emma",           LastName ="Stone"},             //22
                    new LeadActor {FirstName ="Humphrey",       LastName ="Bogart"},            //23//Casablanca
                    new LeadActor {FirstName ="Ingrid",         LastName ="Bergman"},           //24
                    new LeadActor {FirstName ="Dev",            LastName ="Patel"},             //25//Slumdog Millionare
                    new LeadActor {FirstName ="Freida",         LastName ="Pinto"},             //26
                    new LeadActor {FirstName ="Roberto",        LastName ="Benigni"},           //27//La vita è bella
                    new LeadActor {FirstName ="Nicoletta",      LastName ="Braschi"},           //28
                    new LeadActor {FirstName ="Tim",            LastName ="Robbins"},           //29+10//The Shawshank Redemption 
                    new LeadActor {FirstName ="Liam",           LastName ="Nelson"},            //30//Schindler's List      
                    new LeadActor {FirstName ="Ralph",          LastName ="Finess"},            //31
                    new LeadActor {FirstName ="John",           LastName ="Travolta"},          //32//Pulp Fiction   
                    new LeadActor {FirstName ="Uma",            LastName ="Thurman"},           //33
                    new LeadActor {FirstName ="Clint",          LastName ="Eastwood"},          //34//The Good, the Bad and the Ugly  
                    new LeadActor {FirstName ="Eli",            LastName ="Wallach"},           //35
                    new LeadActor {FirstName ="Edward",         LastName ="Norton"},            //11+36 //Flight Club  
                    new LeadActor {FirstName ="Matt",           LastName ="Damon"},             //19+37 //Saving Private Ryan
                    new LeadActor {FirstName ="Ray",            LastName ="Liotta"},            //15+38 //Goodfellas
                    new LeadActor {FirstName = "Ellen",         LastName = "DeGeneres"},       //39, Finding Nemo
                    new LeadActor {FirstName = "Albert",        LastName ="Brooks" },            //40
                    new LeadActor {FirstName = "Matthew",       LastName ="Broderick"},        //41 Lion King
                    new LeadActor {FirstName = "Jeremy",        LastName ="Irons" },             //42
                    new LeadActor {FirstName = "Ben",           LastName ="Burtt" },                //43 Wall-E
                    new LeadActor {FirstName = "Elissa",        LastName ="Knight" },              //44
                    new LeadActor {FirstName = "Tim",           LastName ="Allen" },           //45 19, ToyStory
                    new LeadActor {FirstName = "Edward",       LastName ="Asner" },        //46Up
                    new LeadActor {FirstName = "Jordan",       LastName ="Nagai" }     //47

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
                    new Rental {RentalDate = DateTime.Parse("2020-10-05"), Customer = Customers[0], Movie = Movies[10]},
                    new Rental {RentalDate = DateTime.Parse("2020-10-31"), Customer = Customers[1], Movie = Movies[7]},
                    new Rental {RentalDate = DateTime.Parse("2020-10-31"), Customer = Customers[2], Movie = Movies[2]},
                    new Rental {RentalDate = DateTime.Parse("2020-11-01"), Customer = Customers[3], Movie = Movies[15]},
                    new Rental {RentalDate = DateTime.Parse("2020-11-10"), Customer = Customers[4], Movie = Movies[20]}
                };
                ctx.AddRange(Rentals);  
                       
               
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