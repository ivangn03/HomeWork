using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfHomework.Domain.Presentation;

namespace WpfHomework.Domain.Models
{
    public class Car: NotifyChange
    {
        private string _model;
        private string _color;
        private int _year;
        public string Model
        {
            get => _model;
            set
            {
                _model = value;
                Notify();
            }
        }
        public string Color {
            get => _color;
            set
            {
                _color = value;
                Notify();
            }
        }
        public int Year {
            get => _year;
            set
            {
                _year = value;
                Notify();
            }
        }
    }
}
