using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieRental.Model;

namespace MovieRental.Repository
{
    class MovieRepository : Repository<Movie>
    {
        private HashSet<Movie> movies;

        public MovieRepository()
        {
            movies = new HashSet<Movie>();
        }

        public virtual int add(Movie movie)
        {
            if (movie != null)
            {
                movies.Add(movie);
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public virtual int remove(long ID)
        {
            if(ID >= 0)
            {
                foreach(Movie m in movies)
                {
                    if(m.getID() == ID)
                    {
                        movies.Remove(m);
                        return 1;
                    }
                }
                return -1;
            }
            else
            {
                return -1;
            }
        }

        public virtual int update(Movie movie)
        {
            if (movie != null)
            {
                foreach (Movie m in movies)
                {
                    if (m.getID() == movie.getID())
                    {
                        movies.Remove(m);
                        movies.Add(movie);
                        return 1;
                    }
                }
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public virtual HashSet<Movie> getAll()
        {
            return this.movies;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Movie m in movies)
            {
                result += m.ToString();
            }

            return result;
        }
    }
}
