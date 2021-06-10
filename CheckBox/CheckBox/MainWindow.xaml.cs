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

namespace CheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Capitales> LiListaCapitales = new List<Capitales>();

            LiListaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            LiListaCapitales.Add(new Capitales { NombreCapital = "Bogotá" });
            LiListaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            LiListaCapitales.Add(new Capitales { NombreCapital = "Mexico DF" });
            LiListaCapitales.Add(new Capitales { NombreCapital = "Santiago" });

            Capitales.ItemsSource = LiListaCapitales;
        }

        private void TodosC_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            Mexico.IsChecked = true;
            Santiago.IsChecked = true;
            
        }

        private void TodosC_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;
            Mexico.IsChecked = false;
            Santiago.IsChecked = false;
        }

        private void Individual_Cheked(object sender, RoutedEventArgs e)
        {
            if(Madrid.IsChecked==true && Bogota.IsChecked==true && Lima.IsChecked==true && Mexico.IsChecked==true && Santiago.IsChecked == true)
            {
                TodosC.IsChecked = true; 
            }
            else
            {
                TodosC.IsChecked = null;
            }
        }

        private void Individual_NoCheked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Bogota.IsChecked == false && Lima.IsChecked == false && Mexico.IsChecked == false && Santiago.IsChecked == false)
            {
                TodosC.IsChecked = false;
            }
            else
            {
                TodosC.IsChecked = null;
            }
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
