using BarberShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.ConsolePL
{
    class Program
    {
        internal static void Print(IEnumerable<string> arr)
        {
            if (arr != null)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void Main(string[] args)
        {
            var userLogic = DependencyResolver.RequestLogic;
            Console.WriteLine("Введите имя клиента ");
            string name = Console.ReadLine();
            DateTime date = DateTime.Parse(Console.ReadLine());
            userLogic.addRequest(name, date);

            Print(userLogic.getAll());
        }
    }
}
