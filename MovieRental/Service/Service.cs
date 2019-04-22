using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Service
{
    interface Service<T>
    {
        int add(T obj);

        int remove(long ID);

        int update(T obj);

        HashSet<T> getAll();
    }
}
