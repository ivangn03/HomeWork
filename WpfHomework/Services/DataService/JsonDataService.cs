using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using WpfHomework.Domain.DataService;
using WpfHomework.Domain.Models;

namespace WpfHomework.Services.DataService
{
    class JsonDataService : IDataService<IEnumerable<Car>>
    {
        string path = "cars.json";
        public IEnumerable<Car> Load()
        {
            if (!File.Exists(path))
            {
                return new List<Car>();
            }
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<IEnumerable<Car>>(json);
        }

        public void Save(IEnumerable<Car> data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
