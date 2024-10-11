using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    public class Movie
    {
        public string movieId {  get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public string rentalPrice { get; set; }

        public int TotalMovies { get; set; }

        


        public Movie(string movieId, string title, string director, string rentalPrice)
        {
            this.movieId = movieId;
            this.title = title;
            this.director = director;
            this.rentalPrice = rentalPrice;
            TotalMovies++;
        }

        public Movie()
        {
            
        }

       

        public override string ToString()
        {
            return $"movieIdId: {movieId}, title: {title}, director: {director}, rentalPrice: {rentalPrice}";
        }


        public virtual string DisplayMovieInfo()
        {
            return ToString() ;
        }
    }


}


