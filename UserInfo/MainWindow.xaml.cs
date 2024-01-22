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

namespace UserInfo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Country { get; set; }
        List<CityCountry> cities = new List<CityCountry>
        {
            new CityCountry {Name="Grozny", Counrty="Russia"},
            new CityCountry {Name = "Brest", Counrty = "Belarus"},
            new CityCountry {Name = "Astana", Counrty = "Kazakhstan"},
            new CityCountry {Name = "Ekaterinburg", Counrty = "Russia"},
            new CityCountry {Name = "Bobruisk", Counrty = "Belarus"},
            new CityCountry {Name = "Almaty", Counrty = "Kazakhstan"},
            new CityCountry {Name = "Chelyabinsk", Counrty = "Russia"},
            new CityCountry {Name = "Vitebsk", Counrty = "Belarus"},
            new CityCountry {Name = "Aktau", Counrty = "Kazakhstan"},
            new CityCountry {Name = "Moscow", Counrty = "Russia"},
            new CityCountry {Name = "Gomel", Counrty = "Belarus"},
            new CityCountry {Name = "Arys", Counrty = "Kazakhstan"}
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_Rectangle(object sender, MouseButtonEventArgs e)
        {
            ListCountres.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            ListCity.Items.Clear();
            Country = (sender as ListViewItem).Content as string;
            foreach (var item in cities)
            {
                if (item.Counrty == Country)
                {
                    ListCity.Height += 30;
                    ListCity.Items.Add(item.Name);
                }
            }
            ListCity.Visibility = Visibility.Visible;
            ListCountres.Visibility = Visibility.Hidden;

        }
    }
    public class CityCountry
    {
        public string Name { get; set; }
        public string Counrty { get; set; }
    }
}
