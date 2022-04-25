using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WepApp.Repository.Interfaces
{
    public interface IGeneric<T>
    {
        Task Add(T model);
        void Edit(T model);
        void Delete(T model);
        Task<IEnumerable<T>> GetAll();
        Task Save();
    }
}
