using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class DigitalMovie :Movie
    {
        public string FileSize { get; set; }
        public string Format { get; set; }

        public DigitalMovie(string movieId, string title, string director, string rentalPrice, string filesize, string format) :base( movieId,  title,  director,  rentalPrice)
        {
            this.FileSize = filesize;
            this.Format = format;
                
        }


        public string DisplayDigitalMovieInfo()
        {
            return $" filesize : {FileSize},  format : {Format}";
        }
    }
}
