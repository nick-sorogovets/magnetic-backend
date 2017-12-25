using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using MagneticAPI.Models;

namespace MagneticAPI.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        private readonly ClientContext _context;
        private readonly ILogger _logger;

        public ClientsRepository(ClientContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger(nameof(ClientsRepository));
        }

        public List<Client> GetAll()
        {
            _logger.LogCritical("Getting all clients");
            return _context.Clients.ToList();
        }

        [HttpPost]
        public void Post(Client client)
        {
            if (_context.Clients.Count(cl => cl.Id == client.Id) == 1)
            {
                _context.Clients.Update(client);
            }
            else
            {
                _context.Clients.Add(client);
            }

            _context.SaveChanges();
        }
    }
}
