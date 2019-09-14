using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHomework.Domain.DataService
{
    public interface IDataService<T>
    {
        T Load();
        void Save(T data);
    }
}
