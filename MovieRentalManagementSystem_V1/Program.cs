using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MovieManager movieManager = new MovieManager();

            while (true)
            {

                Console.WriteLine("Movie Rental Management System:");
                Console.WriteLine("1. Add a Movie");
                Console.WriteLine("2. View All Movies");
                Console.WriteLine("3. Update a Movie");
                Console.WriteLine("4. Delete a Movie");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");

                var chek = Console.ReadLine();

                switch (chek)
                {
                    case "1":
                        clearConsole();
                        Console.WriteLine("1. Add a Movie");

                        Console.Write("Enter Id: ");
                        string id = Console.ReadLine();
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter director: ");
                        string director = Console.ReadLine();
                        Console.Write("Enter rentalprice: ");
                        string rentalprice = Console.ReadLine();

                        //decimal ValidateMovieRentalPrice = movieManager.ValidateMovieRentalPrice(rentalprice);

                        movieManager.CreateMovie(new Movie(id, title, director, rentalprice));

                        break;


                    case "2":
                        clearConsole();
                        Console.WriteLine("2. View All Movies");

                        movieManager.ReadMovies();



                        break;


                    case "3":
                        clearConsole();
                        Console.WriteLine("3. Update a Movie");

                        Console.Write("Enter Id: ");
                        string updateid = Console.ReadLine();
                        Console.Write("Enter newtitle: ");
                        string newtitle = Console.ReadLine();
                        Console.Write("Enter newdirector: ");
                        string newdirector = Console.ReadLine();
                        Console.Write("Enter newrentalprice: ");
                        string newrentalprice = Console.ReadLine();
                        //decimal ValidateMovieupdateRentalPrice = movieManager.ValidateMovieRentalPrice(newrentalprice);

                        movieManager.UpdateMovie(updateid, newtitle, newdirector, newrentalprice);


                        break;


                    case "4":
                        clearConsole();
                        Console.WriteLine("4. Delete a Movie");

                        Console.Write("Enter Id: ");
                        string deleteid = Console.ReadLine();

                        movieManager.DeleteMovie(deleteid);



                        break;


                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        clearConsole();
                        Console.WriteLine("Enter Correct No");
                        break;



                }


            }




            void clearConsole()
            {
                Console.Clear();
            }





        }


    }
}




