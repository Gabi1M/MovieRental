using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieRental.Model;
using MovieRental.Repository;

namespace MovieRental.Service
{
    class RentService : Service<Rent>
    {
        private RentRepository rentRepository;

        public RentService(RentRepository rentRepository)
        {
            this.rentRepository = rentRepository;
        }

        public virtual int add(Rent rent)
        {
            return this.rentRepository.add(rent);
        }

        public virtual int remove(long ID)
        {
            return this.rentRepository.remove(ID);
        }

        public virtual int update(Rent rent)
        {
            return this.rentRepository.update(rent);
        }

        public virtual HashSet<Rent> getAll()
        {
            return this.rentRepository.getAll();
        }

        public virtual Rent getByID(long ID)
        {
            return this.rentRepository.getByID(ID);
        }
    }
}
