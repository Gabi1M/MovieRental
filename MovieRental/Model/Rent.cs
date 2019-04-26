using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Model
{
    class Rent : BaseEntity
    {
        private long idClient;
        private long idMovie;

        public Rent()
        {

        }

        public Rent(long idClient, long idMovie)
        {
            this.idClient = idClient;
            this.idMovie = idMovie;
        }

        public long getIdClient()
        {
            return this.idClient;
        }

        public void setIdClient(long idClient)
        {
            this.idClient = idClient;
        }

        public long getIdMovie()
        {
            return this.idMovie;
        }

        public void setIdMovie(long idMovie)
        {
            this.idMovie = idMovie;
        }

        public override string ToString()
        {
            return base.ToString() + " Rent { idClient: " + this.idClient + ", idMovie:" + this.idMovie + " } ";
        }
    }
}
