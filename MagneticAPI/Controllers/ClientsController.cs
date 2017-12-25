using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using MagneticAPI.Models;
using MagneticAPI.Repositories;

namespace MagneticAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/clients")]
    public class ClientsController : Controller
    {
        private readonly IClientsRepository _clientsRepository;


        public ClientsController(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _clientsRepository.GetAll();
        }


        [HttpPost]
        public void Post([FromBody] Client value)
        {
            _clientsRepository.Post(value);
        }


    }
}