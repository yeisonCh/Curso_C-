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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace GestionPedidos
{
    /// <summary>
    /// Lógica de interacción para Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {

        private int z;
        public Actualiza(int elId)
        {
            InitializeComponent();
            //cadena de conexion
            //estable la conexión con la base de datos 

            z = elId;
            string miConexion = ConfigurationManager.ConnectionStrings["GestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            //establece la conexion sql
            miConexionSql = new SqlConnection(miConexion);

        }

        SqlConnection miConexionSql;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "update cliente set nombre=@nombre where id=" + z;

            SqlCommand miSqlComand = new SqlCommand(consulta, miConexionSql);
            //abrir la conexion sql 
            miConexionSql.Open();

            //la siguiente instrucción nos dice que el parametro @nombre se toma del cuadro con nombre insertaCliente y se rescata el texto que esta alli dentro
            miSqlComand.Parameters.AddWithValue("@nombre", cuadroActualiza.Text);

            //ejecutamos la cosnulta 

            miSqlComand.ExecuteNonQuery();

            miConexionSql.Close();//cerramos la conexion a la base de datos

            this.Close();// el this hace referencia a la clase donde estamos 
            
         }
    }
}
