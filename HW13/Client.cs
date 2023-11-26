using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    class Client
    {
        public string Id { get; }
        public string Service { get; }

        public Client(string id, string service)
        {
            Id = id;
            Service = service;
        }
    }
}
