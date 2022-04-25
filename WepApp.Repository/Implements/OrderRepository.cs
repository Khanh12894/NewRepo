using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WepApp.Repository.Interfaces;

namespace WepApp.Repository.Implements
{
    public class OrderRepository : IOrder
    {
        public Task Add(IOrder model)
        {
            throw new NotImplementedException();
        }

        public void Delete(IOrder model)
        {
            throw new NotImplementedException();
        }

        public void Edit(IOrder model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IOrder>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
