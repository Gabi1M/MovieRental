using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieRental.Model;
using MovieRental.Repository;

namespace MovieRental.Service
{
    class MovieService : Service<Movie>
    {
        private MovieRepository movieRepository;

        public MovieService(MovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public virtual int add(Movie movie)
        {
            return movieRepository.add(movie);
        }

        public virtual int remove(long ID)
        {
            return movieRepository.remove(ID);
        }

        public virtual int update(Movie movie)
        {
            return movieRepository.update(movie);
        }

        public virtual HashSet<Movie> getAll()
        {
            return movieRepository.getAll();
        }

        public virtual Movie getByID(long ID)
        {
            return this.movieRepository.getByID(ID);
        }
    }
}
