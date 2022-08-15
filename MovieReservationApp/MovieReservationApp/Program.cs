using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var theatres = new List<Theatre>()
            {
                new Theatre(){ TheatreName = "Show Max", TheatreCapacity = 2000, TheatreLocation = "Benue" },
                new Theatre(){ TheatreName = "Silver Bird", TheatreCapacity = 5000, TheatreLocation = "Abuja" },
                new Theatre(){ TheatreName = "Genesis Studio", TheatreCapacity = 8000, TheatreLocation = "Lagos" }
            };

            var movies = new List<Movie>();
            var viewers = new Dictionary<long, Viewer>();

            while (true)
            {
                Console.WriteLine("Commands: Register Viewer, Add Movie, Sell Movie Ticket, View Movie Details");
                var command = Console.ReadLine();
                if (command == "Register Viewer")
                {
                    Console.WriteLine("Enter name of viewer");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter phone number of viewer");
                    var phoneNumber = long.Parse(Console.ReadLine());

                    viewers.Add(phoneNumber, new Viewer { Name = name, PhoneNumber = phoneNumber });
                    Console.WriteLine("Viewer registered successfully");
                }else if (command == "Add Movie")
                {
                    Console.WriteLine("Enter movie title");
                    var movieTitle = Console.ReadLine();
                    Console.WriteLine("Enter date of show");
                    var dateOfShow = Console.ReadLine();
                    Console.WriteLine("Enter theatre name");
                    var theatreName = Console.ReadLine();
                    var theatre = theatres.Where(x => x.TheatreName == theatreName).First();

                    movies.Add(new Movie { MovieTitle = movieTitle, DateOfShow = dateOfShow, Theatre = theatre });
                    Console.WriteLine("Movie Added Successfully");
                }else if (command == "Sell Movie Ticket")
                {
                    Console.WriteLine("Enter phone number of viewer");
                    var phoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter movie beign payed for");
                    var movieTitle = Console.ReadLine();
                    
                    var viewer = viewers[phoneNumber];
                    var movie = movies.Where(x => x.MovieTitle == movieTitle).First();
                    movie.Viewers.Add(viewer);
                    Console.WriteLine("Viewer added successfully to this movie");
                }else if (command == "View Movie Details")
                {
                    Console.WriteLine("Enter movie title to check details");
                    var movieTitle = Console.ReadLine();
                    var movie = movies.Where(x => x.MovieTitle == movieTitle).First();
                    Console.WriteLine($"Movie title: {movie.MovieTitle}, Date of show: {movie.DateOfShow}, Thetre of play: {movie.Theatre}");

                    //Display all viewers of this particular movie
                    foreach(var viewer in movie.Viewers)
                    {
                        Console.WriteLine($"Name: {viewer.Name}, Phone number: {viewer.PhoneNumber}");
                    }
                }
            }
        }
    }
}