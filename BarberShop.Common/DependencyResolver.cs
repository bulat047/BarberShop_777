using BarberShop.BLL;
using BarberShop.DAL;
using BarberShop.DAL.Interface;
using BarderShop.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Common
{
    public static class DependencyResolver
    {
        private static IRequestFakeDao _requestDao;

        public static IRequestFakeDao RequestDao => _requestDao ?? (_requestDao = new RequestFakeDao());

        private static IBarberShopLogic _barberShopLogic;

        public static IBarberShopLogic RequestLogic => _barberShopLogic ?? (_barberShopLogic = new BarberShopLogic(RequestDao));
    }
}
