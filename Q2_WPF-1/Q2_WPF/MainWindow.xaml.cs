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
using System.Net;
using Newtonsoft.Json;
using Q2_WPF.Models;

namespace Q2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (WebClient wc = new WebClient())
            {
                string url = "https://jsonplaceholder.typicode.com/users?_limit=5";
                string json = wc.DownloadString(url);
                Employee p1 = new Employee();
                List<Employee> data = JsonConvert.DeserializeObject<List<Employee>>(json);
                //Employee.Content = Employee.Display_Employee(data);
            }
        }
    }
}
