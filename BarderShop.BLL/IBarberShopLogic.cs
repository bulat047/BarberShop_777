using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarderShop.BLL.Interface
{
    public interface IBarberShopLogic
    {
        void addRequest(string name, DateTime date);

        IEnumerable<string> getAll();
    }
}
