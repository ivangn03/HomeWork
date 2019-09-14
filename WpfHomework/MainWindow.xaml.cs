using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfHomework.Domain.Models;
using WpfHomework.Domain.Repositories;
using WpfHomework.Services.Presentation;

namespace WpfHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Data data;
        public MainWindow(Data data)
        {
            this.data = data;
            InitializeComponent();            
            grid.DataContext = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            data.AddCar(new Car { Color = "Null", Model = "Null", Year = 0 });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            data.RemoveCar();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            data.Save();
        }
    }
}
