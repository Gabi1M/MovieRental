using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieRental.Model;

namespace MovieRental.Repository
{
    class ClientRepository : Repository<Client>
    {
        private HashSet<Client> clients;

        public ClientRepository()
        {
            clients = new HashSet<Client>();
        }

        public virtual int add(Client client)
        {
            if(client != null)
            {
                clients.Add(client);
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
                foreach(Client c in clients)
                {
                    if(c.getID() == ID)
                    {
                        clients.Remove(c);
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

        public virtual int update(Client client)
        {
            if(client != null)
            {
                foreach(Client c in clients)
                {
                    if(c.getID() == client.getID())
                    {
                        clients.Remove(c);
                        clients.Add(client);
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

        public virtual HashSet<Client> getAll()
        {
            return this.clients;
        }

        public virtual Client getByID(long ID)
        {
            foreach(Client c in clients)
            {
                if(c.getID() == ID)
                {
                    return c;
                }
            }

            return null;
        }

        public override string ToString()
        {
            string result = "";
            foreach(Client c in clients)
            {
                result += c.ToString();
            }

            return result;
        }
    }
}
