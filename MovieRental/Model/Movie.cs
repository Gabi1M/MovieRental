using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Model
{
    class Movie : BaseEntity
    {
        private string name;
        private string genre;
        private int duration;
        private int year;

        public Movie()
        {

        }

        public Movie(string name, string genre, int duration, int year)
        {
            this.name = name;
            this.genre = genre;
            this.duration = duration;
            this.year = year;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getGenre()
        {
            return this.genre;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }

        public int getDuration()
        {
            return this.duration;
        }

        public void setDuration(int duration)
        {
            this.duration = duration;
        }

        public int getYear()
        {
            return this.year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public override string ToString()
        {
            return base.ToString() + "Movie { Name = " + this.name + ", Genre = " + this.genre + ", Duration = " + this.duration + ", Year = " + this.year + "}";
        }
    }
}
