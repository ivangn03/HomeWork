using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfHomework.Domain.DataService;
using WpfHomework.Domain.Models;
using WpfHomework.Domain.Repositories;

namespace WpfHomework.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        IDataService<IEnumerable<Car>> dataService;
        List<Car> list;
        public CarRepository(IDataService<IEnumerable<Car>> dataService)
        {
            this.dataService = dataService;
            list = (dataService.Load()) as List<Car>;
        }
        public void Create(Car data)
        {
            list.Add(data);
        }

        public void Delete(Car data)
        {
            list.Remove(this.Get(data.Id));
        }

        public Car Get(int id)
        {
            return list.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Car> GetAll()
        { 
            return list;
        }

        public void SaveAll()
        {
            dataService.Save(list);
        }
    }
}
