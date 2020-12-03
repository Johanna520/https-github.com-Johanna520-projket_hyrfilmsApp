using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DatabaseConnection;

namespace FleraVyer.SubViews
{  
    static class State
    {
        public static Customer User { get; set; } // Användaren som loggat in
        public static List<Movie> Movies { get; set; } // Filmer jag hämtat från databasen
        public static Movie Pick { get; set; } // Film som användaren valt att hyra
        
        public static Rental Rentals { get; set; }
    }
}
