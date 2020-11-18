using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnection
{
 
        public class Customer
        {
            public int CustomerId { get; set; }            //PK
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Birthday { get; set; }
            public  List<Rental> Rentals { get; set; } //Vid användnig av LazyLoading lägg till: virtual efter public

        */
        public class Movie
        {
            public int MovieId { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public double ImbdRating { get; set; }
            public string ImageURL { get; set; }
            public virtual List<Genre> Genres { get; set; }
            public virtual List<LeadActor> LeadActors { get; set; }
        }
       
        
            /*
        Rental      Johanna
        RentalId
        RentalDate
        MovieId (FK)
        CustomerId (FK)
            */
        public class Genre
        {
            public int GenreId { get; set; }
            public string GenreName { get; set; }
            public virtual List<Movie> Movies { get; set; }
        }
      
        
            /*
        Leadactor       JOhanna
        LeadactorId
        FirstName 
        LastName    

         */
    }
        }
       
            /*
        Movie           Jens
        MovieId (PK)
        Title
        Year
        ImbdRating
        ImageURL
        GenreId (FK)
        LeadactorId (FK)*/

        public class Rental
        {
            public int RentalId { get; set; }
            public string RentalDate { get; set; } //Obs... Här går även göra en datetime och därefter ev. göra en parse. 
                                                   //Kolla med Alexander F isåfall :) 
            //public  Movie Movies { get; set; } - lägg till virtual vid LazyLoading
            public Customer Customer { get; set; } //lägg till virtual vid LazyLoading


        }

            /*

        Genre           Jens
        GenreId
        GenreName
            */
        public class Leadactor
        {
            public int LeadactorId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }       
                 
   
}
