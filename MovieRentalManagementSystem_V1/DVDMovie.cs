using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class DVDMovie : Movie
    {
        public string DiscWeight { get; set; }
        public string Duration { get; set; }


        public DVDMovie(string movieId, string title, string director, string rentalPrice, string discWeight, string duration) : base(movieId, title, director, rentalPrice)
        {
            this.DiscWeight = discWeight;
            this.Duration = duration;

        }

        public string DisplayDVDMovieInfo()
        {
            return $" DiscWeight : {DiscWeight},  Duration : {Duration}";
        }


        public override string DisplayMovieInfo()
        {
            return $"{base.DisplayMovieInfo()} DiscWeight : {DiscWeight},  Duration : {Duration}";
        }

    }
}
