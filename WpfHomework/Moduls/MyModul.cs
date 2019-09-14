using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using WpfHomework.Domain.DataService;
using WpfHomework.Domain.Models;
using WpfHomework.Domain.Repositories;
using WpfHomework.Repositories;
using WpfHomework.Services.DataService;
using WpfHomework.Services.Presentation;

namespace WpfHomework.Moduls
{
    class MyModul : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Car>>().To<CarRepository>();
            Bind<Data>().To<Data>();
            Bind<IDataService<IEnumerable<Car>>>().To<JsonDataService>();
        }
    }
}
