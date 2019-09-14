using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfHomework.Domain.Models;
using WpfHomework.Domain.Repositories;

namespace WpfHomework.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        List<Car> list;
        public CarRepository()
        {
            list = new List<Car>();
        }
        public void Create(Car data)
        {
            list.Add(data);
        }

        public void Delete(Car data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        { 
            list.Add(new Car { Model = "Model1", Color = "Color1", Year = 2019 });
            list.Add(new Car { Model = "Model2", Color = "Color2", Year = 2018 });
            list.Add(new Car { Model = "Model3", Color = "Color3", Year = 2017 });
            list.Add(new Car { Model = "Model4", Color = "Color4", Year = 2016 });
            return list;
        }

        public void SaveAll()
        {
            throw new NotImplementedException();
        }
    }
}
