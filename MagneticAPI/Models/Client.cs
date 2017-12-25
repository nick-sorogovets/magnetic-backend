using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagneticAPI.Models
{
    public class Client
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public DateTime Birthday { get; set; }
    }
}
