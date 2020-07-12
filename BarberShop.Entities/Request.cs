using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Entities
{
    public class Request
    {
        public string name;

        public DateTime date;

        public override string ToString()
        {
            return $"{string.Join(" ", name, date)}";
        }
    }
}
