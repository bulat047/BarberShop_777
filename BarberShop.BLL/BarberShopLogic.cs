using BarberShop.DAL.Interface;
using BarberShop.Entities;
using BarderShop.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.BLL
{
    public class BarberShopLogic : IBarberShopLogic
    {
        private readonly IRequestFakeDao _requestDao;


        public BarberShopLogic(IRequestFakeDao requestDao)
        {
            _requestDao = requestDao;
        }

        public void addRequest(string name, DateTime date)
        {
            Request r = new Request();
            r.name = name;
            r.date = date;
            _requestDao.AddRequest(r);
        }

        public IEnumerable<string> getAll()
        {
            return _requestDao.GetAll();
        }
    }
}
