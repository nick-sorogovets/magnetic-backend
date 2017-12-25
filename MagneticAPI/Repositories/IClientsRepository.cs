using MagneticAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagneticAPI.Repositories
{
    public interface IClientsRepository
    {
        List<Client> GetAll();

        void Post(Client client);
    }
}
