using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class MovieManager  
    {
        List<Movie> movies = new List<Movie>();



        public void CreateMovie(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine("Movie Added Successfully!!!!!!");
        }

        public void ReadMovies()
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }

        public void UpdateMovie(string movieId, string newtitle, string newdirector, string newrentalPrice)
        {
            var update = movies.Find(x => x.movieId == movieId);
            if (update != null)
            {



                update.title = newtitle;
                update.director = newdirector;
                update.rentalPrice = newrentalPrice;

                Console.WriteLine("updated");


            }
            else
            {
                Console.WriteLine("correct id");
            }


        }



       

            public void DeleteMovie(string id)
        {
            movies.RemoveAll(x => x.movieId == id);
            Console.WriteLine("deleted");

        }


        public string ValidateMovieRentalPrice(string price)
        {
            if (Convert.ToDecimal(price)> 0)
            {
                return price;

            }
            else
            {
                while (Convert.ToDecimal(price) <= 0)
                {
                    Console.WriteLine("Enter poitive Value");
                    Console.Write("ReenterValue :  ");

                    price = Console.ReadLine();


                }
                return price;
            }
        }



    }
}
