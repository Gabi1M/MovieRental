using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Model
{
    public abstract class BaseEntity
    {
        private long ID;

        public long getID()
        {
            return this.ID;
        }

        public void setID(long ID)
        {
            this.ID = ID;
        }

        public override string ToString()
        {
            return "BaseEntity { ID = " + this.ID + " } ";
        }
    }
}
