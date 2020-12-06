using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// skriv in fler queries, vad hände i varje steg? 

namespace DatabaseConnection
{
    public static class DatabaseAPI
    {
        static Context ctx;

        static DatabaseAPI()
        {
            ctx = new Context();
        }
        public static List<Movie> GetMovieSlice(int skip_x, int take_x)
        {
            return ctx.Movies
                .OrderBy(m => m.Title)
                .Skip(skip_x)
                .Take(take_x)
                .ToList();
        }
        public static Customer GetCustomerByName(string FirstName)
        {
            return ctx.Customers
                .FirstOrDefault(c => c.FirstName.ToLower() == FirstName.ToLower());
        }
        public static bool RegisterSale(Customer customer, Movie movie)
        {
            try
            {
                ctx.Add(new Rental() { RentalDate = DateTime.Now, Customer = customer, Movie = movie });

                bool one_record_added = ctx.SaveChanges() == 1;
                return one_record_added;
            }
            catch (DbUpdateException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                System.Diagnostics.Debug.WriteLine(e.InnerException.Message);
                return false;
            }

        }
        public static List<Movie> GetMovieByName(string title)
        {
            return ctx.Movies.AsEnumerable().Where(m => m.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static List<Movie> GetMovieByRating(int a, int b)
        {
            return ctx.Movies.OrderByDescending(r => r.ImbdRating).Skip(a).Take(b).ToList();
        }
        public static List<Movie> GetMovieByYear(int year)
        {
            return ctx.Movies
                .OrderBy(m => m.Year)
                .Where(m => m.Year == year)
                .ToList(); 
        }

    }

}

