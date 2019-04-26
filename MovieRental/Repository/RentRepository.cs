using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieRental.Model;

namespace MovieRental.Repository
{
    class RentRepository : Repository<Rent>
    {
        private HashSet<Rent> rents;

        public RentRepository()
        {
            this.rents = new HashSet<Rent>();
        }

        public virtual int add(Rent rent)
        {
            if(rent != null)
            {
                this.rents.Add(rent);
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public virtual int remove(long ID)
        {
            if (ID >= 0)
            {
                foreach (Rent r in rents)
                {
                    if (r.getID() == ID)
                    {
                        rents.Remove(r);
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

        public virtual int update(Rent rent)
        {
            if (rent != null)
            {
                foreach (Rent r in rents)
                {
                    if (r.getID() == rent.getID())
                    {
                        rents.Remove(r);
                        rents.Add(rent);
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

        public HashSet<Rent> getAll()
        {
            return this.rents;
        }

        public Rent getByID(long ID)
        {
            foreach(Rent r in rents)
            {
                if(r.getID() == ID)
                {
                    return r;
                }
            }

            return null;
        }

        public override string ToString()
        {
            string result = "";
            foreach(Rent r in rents)
            {
                result += r.ToString();
            }

            return result;
        }
    }
}
