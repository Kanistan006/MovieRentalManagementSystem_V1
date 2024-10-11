﻿using System;
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
            if (movieId != null)
            {
                var updateid = movies.Find(x => x.movieId == movieId);

                var obj = new Movie
                {
                    title = newtitle,
                    director= newdirector,
                    rentalPrice = newrentalPrice
                };

                movies.Add(obj);

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
    }
}
