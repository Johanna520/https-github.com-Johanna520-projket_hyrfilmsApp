using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnection
{

    public class Customer
    {
        public int CustomerId { get; set; }         //PK
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public virtual List<Rental> Rentals { get; set; }      

    }
    public class Movie
    {
        public int MovieId { get; set; }        // PK
        public string Title { get; set; }
        public int Year { get; set; }
        public double ImbdRating { get; set; }
        public string ImageURL { get; set; }
        public virtual List<Genre> Genres { get; set; }     // FK (many)
        public virtual List<LeadActor> LeadActors { get; set; }     // FK (many)
        }
    public class Genre
    {
        public int GenreId { get; set; }       // PK
        public string GenreName { get; set; }
        public virtual List<Movie> Movies { get; set; }    // FK (many)
    }
    public class Rental
    {
        public int RentalId { get; set; }      // PK
        public DateTime RentalDate { get; set; }     //Obs... Här går även göra en datetime och därefter ev. göra en parse. 
                                                    //Kolla med Alexander F isåfall :) 
        public virtual Movie Movie { get; set; }      // FK (one)                                                         
        public virtual Customer Customer { get; set; }     // FK (one)    
                                                             
    }
    public class LeadActor
    {
        public int LeadActorId { get; set; }       // PK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Movie> Movies { get; set; }     // FK (many)
    }       
                 
   
}
