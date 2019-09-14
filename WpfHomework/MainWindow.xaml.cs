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
        Data data1;
        public MainWindow(Data data)
        {
            this.data1 = data;
            InitializeComponent();            
            grid.DataContext = data;
        }
    }
}
