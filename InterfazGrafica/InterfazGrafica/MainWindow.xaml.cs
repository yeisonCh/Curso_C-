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

namespace InterfazGrafica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid migrid = new Grid();

            this.Content = migrid;

            Button miBoton = new Button();

            miBoton.Width = 140;
            miBoton.Height = 75;
            miBoton.Background = Brushes.Green;

            WrapPanel miWrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "Click";
            txt1.Background = Brushes.Red;
            txt1.Foreground = Brushes.White;
            miWrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "enviar";
            miWrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Dale!";
            miWrap.Children.Add(txt3);

            miBoton.Content = miWrap;

            migrid.Children.Add(miBoton);
        }
    }
}
