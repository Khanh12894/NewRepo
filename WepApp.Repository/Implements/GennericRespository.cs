using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WepApp.Repository.Interfaces;
using WepApp.Repository.Models;

namespace WepApp.Repository.Implements
{
    public class GennericRespository<T>  where T : class
    {
        public readonly DataContext _dataContext;
        public GennericRespository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        public async Task Add(T model)
        {
            await _dataContext.Set<T>().AddAsync(model);
            
        }

        public void Delete(T model)
        {
            throw new NotImplementedException();
        }

        public void Edit(T model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
