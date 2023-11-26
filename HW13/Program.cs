using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    internal class Program
    {
        static void Main()
        {
            BankQueue bankQueue = new BankQueue();

            while (true)
            {
                Console.WriteLine("1. Встать в очередь");
                Console.WriteLine("2. Обслужить следующего клиента");
                Console.WriteLine("3. Выход");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите ИИН: ");
                        string id = Console.ReadLine();
                        Console.Write("Выберите услугу: ");
                        string service = Console.ReadLine();
                        bankQueue.Enqueue(new Client(id, service));
                        break;

                    case 2:
                        if (bankQueue.Count > 0)
                        {
                            Client nextClient = bankQueue.Dequeue();
                            Console.WriteLine($"Обслужен клиент: {nextClient.Id}. Осталось в очереди: {bankQueue.Count}");
                        }
                        else
                        {
                            Console.WriteLine("Очередь пуста.");
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
    }
}
