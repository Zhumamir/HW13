using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    class BankQueue
    {
        private Queue<Client> clients = new Queue<Client>();

        public void Enqueue(Client client)
        {
            clients.Enqueue(client);
            DisplayQueue();
        }

        public Client Dequeue()
        {
            if (clients.Count > 0)
            {
                return clients.Dequeue();
            }
            return null;
        }

        public int Count => clients.Count;

        private void DisplayQueue()
        {
            Console.WriteLine("Текущая очередь:");
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Id} - {client.Service}");
            }
        }
    }
}
