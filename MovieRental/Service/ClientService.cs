using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieRental.Model;
using MovieRental.Repository;

namespace MovieRental.Service
{
    class ClientService : Service<Client>
    {
        private ClientRepository clientRepository;

        public ClientService(ClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public virtual int add(Client client)
        {
            return clientRepository.add(client);
        }

        public virtual int remove(long ID)
        {
            return clientRepository.remove(ID);
        }

        public virtual int update(Client client)
        {
            return clientRepository.update(client);
        }

        public virtual HashSet<Client> getAll()
        {
            return clientRepository.getAll();
        }

        public virtual Client getByID(long ID)
        {
            return this.clientRepository.getByID(ID);
        }

    }
}
