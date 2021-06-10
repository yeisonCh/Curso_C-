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

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPob = new List<Poblaciones>();

            listaPob.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Balcelona", Temperatura1 = 15, Temperatura2 = 17, Diferencia=2});
            listaPob.Add(new Poblaciones() { Poblacion1 = "Valencia", Poblacion2 = "Alicante", Temperatura1 = 18, Temperatura2 = 10, Diferencia=8});
            listaPob.Add(new Poblaciones() { Poblacion1 = "Málaga", Poblacion2 = "Bilbao", Temperatura1 = 10, Temperatura2 = 14, Diferencia=4 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Coruña", Temperatura1 = 15, Temperatura2 = 22, Diferencia=7});

            ListaPoblaciones.ItemsSource = listaPob;//con esta linea indicamos que la información de la lista la tomaremos de listaPob
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + "  " +
                (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C    " +
                (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + "  " +
                (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C ");
            }
            else
            {
                MessageBox.Show("Selecciona primero un elemento");
            }
                
        }


        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + "  " +
                (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C    " +
                (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + "  " +
                (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C ");
            }
            else
            {
                MessageBox.Show("Selecciona primero un elemento");
            }

        }
    }


    public class Poblaciones
    {

        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }

        public int Diferencia { get; set; }
    }
}