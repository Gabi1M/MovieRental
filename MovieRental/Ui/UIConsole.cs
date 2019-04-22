using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieRental.Service;
using MovieRental.Repository;
using MovieRental.Model;

namespace MovieRental.Ui
{
    class UIConsole
    {
        private ClientService clientService;
        private MovieService movieService;

        public UIConsole()
        {
            this.clientService = new ClientService(new ClientRepository());
            this.movieService = new MovieService(new MovieRepository());
        }

        public void printMenu()
        {
            Console.WriteLine("1. Add client.");
            Console.WriteLine("2. Add movie.");
            Console.WriteLine("3. Remove client.");
            Console.WriteLine("4. Remove movie.");
            Console.WriteLine("5. Update client.");
            Console.WriteLine("6. Update movie.");
            Console.WriteLine("7. Print all clients.");
            Console.WriteLine("8. Print all movies.");
        }

        public void run()
        {
            int choice = 1;

            do
            {
                printMenu();
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 0:
                        {
                            break;
                        }

                    case 1:
                        {
                            Console.WriteLine("Give id: ");
                            long id = long.Parse(Console.ReadLine());
                            Console.WriteLine("Give name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Give gender: ");
                            string gender = Console.ReadLine();
                            Console.WriteLine("Give age: ");
                            int age = int.Parse(Console.ReadLine());

                            Client client = new Client(name, gender, age);
                            client.setID(id);

                            if(clientService.add(client) == 1)
                            {
                                Console.WriteLine("Client added successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Give id: ");
                            long id = long.Parse(Console.ReadLine());
                            Console.WriteLine("Give name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Give genre: ");
                            string genre = Console.ReadLine();
                            Console.WriteLine("Give duration: ");
                            int duration = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give year: ");
                            int year = int.Parse(Console.ReadLine());

                            Movie movie = new Movie(name, genre, duration, year);
                            movie.setID(id);

                            if(movieService.add(movie) == 1)
                            {
                                Console.WriteLine("Movie added successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Error!");
                            }

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Give id: ");
                            long id = long.Parse(Console.ReadLine());

                            if(clientService.remove(id) == 1)
                            {
                                Console.WriteLine("Client removed successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }

                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Give id: ");
                            long id = long.Parse(Console.ReadLine());

                            if (movieService.remove(id) == 1)
                            {
                                Console.WriteLine("Movie removed successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }

                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Give id: ");
                            long id = long.Parse(Console.ReadLine());
                            Console.WriteLine("Give name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Give gender: ");
                            string gender = Console.ReadLine();
                            Console.WriteLine("Give age: ");
                            int age = int.Parse(Console.ReadLine());

                            Client client = new Client(name, gender, age);
                            client.setID(id);

                            if(clientService.update(client) == 1)
                            {
                                Console.WriteLine("Client updated successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }

                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Give id: ");
                            long id = long.Parse(Console.ReadLine());
                            Console.WriteLine("Give name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Give genre: ");
                            string genre = Console.ReadLine();
                            Console.WriteLine("Give duration: ");
                            int duration = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give year: ");
                            int year = int.Parse(Console.ReadLine());

                            Movie movie = new Movie(name, genre, duration, year);
                            movie.setID(id);

                            if (movieService.update(movie) == 1)
                            {
                                Console.WriteLine("Movie updated successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }

                            break;
                        }

                    case 7:
                        {
                            HashSet<Client> clients = clientService.getAll();
                            foreach(Client c in clients)
                            {
                                Console.WriteLine(c.ToString());
                            }
                            break;
                        }

                    case 8:
                        {
                            HashSet<Movie> movies = movieService.getAll();
                            foreach(Movie m in movies)
                            {
                                Console.WriteLine(m.ToString());
                            }
                            break;
                        }
                }
            } while (choice != 0);
        }
    }
}
