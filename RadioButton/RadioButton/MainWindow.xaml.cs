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

namespace RadioButton
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_ClickRojo(object sender, RoutedEventArgs e)
        {
            rojo.Visibility = Visibility.Visible;
            amarillo.Visibility = Visibility.Hidden;
            verde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_ClickAmarillo(object sender, RoutedEventArgs e)
        {

            rojo.Visibility = Visibility.Hidden;
            amarillo.Visibility = Visibility.Visible;
            verde.Visibility = Visibility.Hidden; ;
        }

        private void RadioButton_ClickVerde(object sender, RoutedEventArgs e)
        {
            rojo.Visibility = Visibility.Hidden;
            amarillo.Visibility = Visibility.Hidden;
            verde.Visibility = Visibility.Visible;
        }
    }
}
