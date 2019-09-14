using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfHomework.Domain.Models;
using WpfHomework.Domain.Repositories;

namespace WpfHomework.Services.Presentation
{
    public class Data
    {
        #region
        IRepository<Car> repository;
        public ObservableCollection<Car> Cars { get; set; }
        public Car SelectedCar { get; set; }
        #endregion

        public Data(IRepository<Car> repository)
        {
            this.repository = repository;
            Cars = new ObservableCollection<Car>(repository.GetAll());
            
        }
        #region
        public void AddCar(Car car)
        {
            Cars.Add(car);
            repository.Create(car);
        }
        public void RemoveCar()
        {
            repository.Delete(SelectedCar);
            Cars.Remove(SelectedCar);         
        }
        public void Save()
        {
            repository.SaveAll();
        }
        #endregion
    }
}
