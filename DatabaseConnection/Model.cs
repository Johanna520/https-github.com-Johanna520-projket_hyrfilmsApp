using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnection
{
    class Model
    {
        /*
        Customer            JOhanna
        CustomerId (PK)
        Email
        FirstName
        LastName
        Birthday

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
