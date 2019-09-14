using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHomework.Domain.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Create(T data);
        void Delete(T data);
        T Get(int id);
        void SaveAll();
    }
}
