using BarberShop.DAL.Interface;
using BarberShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.DAL
{
    public class RequestFakeDao : IRequestFakeDao
    {
        private static List<Request> _repoRequest = new List<Request>();

        public void AddRequest(Request r)
        {
            _repoRequest.Add(r);
        }

        public IEnumerable<string> GetAll()
        {
            foreach (var item in _repoRequest)
            {
                yield return item.ToString();
            }
        }
    
    }
}
