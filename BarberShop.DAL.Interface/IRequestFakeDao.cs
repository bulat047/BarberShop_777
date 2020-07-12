using BarberShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.DAL.Interface
{
    public interface IRequestFakeDao
    {
        void AddRequest(Request r);

        IEnumerable<string> GetAll();
    }
}
