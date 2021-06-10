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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;//declaramos el campo de clase 

        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();

            PedidosTodos();

        }

        //creamos un metodo para mostrar clientes 
        private void MuestraClientes()
        {
            //instrucción sql o consulta para ir a la tabla clientes 
            string consulta = "Select * from Cliente";

            //Creamos una clese para obtener los resultados de la consulta y tenerlos en un dataTable
            //con el metodo SqlDataAdapter el cual nos vale para consultas sencillas (NO PARAMETRICAS)
            SqlDataAdapter miAdptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            //Almacenamos en un dataTable usando la palabra reservada using
            using (miAdptadorSql)
            {
                DataTable clientesTabla = new DataTable();

                //Utilizamos el adaptador para rellenar noestro DataTable
                miAdptadorSql.Fill(clientesTabla);//el metodo FILL nos permite rellenar el dataTable

                listaClientes.DisplayMemberPath = "nombre";//especificamos de la tabla cual es el campo que queremos ver 
                listaClientes.SelectedValuePath = "Id";//especificamos el campo clave de la tabla
                listaClientes.ItemsSource = clientesTabla.DefaultView;// especificamos de donde viene la información 
             }
            
        }

        //metodo para cargar los pedidos de los clientes 
        private void MuestraPedido()
        {
            //instrucción sql de forma parametrica
            string consulta = "SELECT * FROM Pedido P INNER JOIN Cliente C ON C.Id=P.cCliente WHERE C.Id=@ClienteId";

            //creamos una instancia a la clase SqlCommand la cual recibe dos parametros
            //la consulta parametrica y la conexión que estamos utilizando

            SqlCommand sqlComando = new SqlCommand(consulta,miConexionSql);

            //en esta ocación modificamos los parametros del objeto sqlDataAdapter y solo le pasamos el objeto sqlComando
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

            //Almacenamos en un dataTable usando la palabra reservada using
            using (miAdaptadorSql)
            {

                // debemos primero obtener los datos que nos debuelbe la consulta con parametros 
                // usando el metodo ActiveValue

                sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);
                DataTable pedidosTabla = new DataTable();

                //Utilizamos el adaptador para rellenar noestro DataTable
                miAdaptadorSql.Fill(pedidosTabla); //el metodo FILL nos rellenar el dataTable

                pedidoCliente.DisplayMemberPath = "fechaPedido";//especificamos de la tabla cual es el campo que queremos ver 
                pedidoCliente.SelectedValuePath = "Id";//especificamos el campo clave de la tabla
                pedidoCliente.ItemsSource = pedidosTabla.DefaultView;// especificamos de donde viene la información 
            }

        }

        private void PedidosTodos()
        {
            //instrucción sql o consulta para ir a la tabla clientes 
            string consulta = "SELECT *, CONCAT (cCliente, ' ',fechaPedido, ' ', formaPago) AS INFORMACION FROM PEDIDO";
            //AGREGAMOS EN LA CONSULTA SQL EL (*) Y LA COMA con el fin de que me selaccione todos los campos de la tabla.




            //Creamos una clese para obtener los resultados de la consulta y tenerlos en un dataTable
            //con el metodo SqlDataAdapter el cual nos vale para consultas sencillas (NO PARAMETRICAS)
            SqlDataAdapter miAdptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            //Almacenamos en un dataTable usando la palabra reservada using
            using (miAdptadorSql)
            {
                DataTable pedidosTabla = new DataTable();

                //Utilizamos el adaptador para rellenar noestro DataTable
                miAdptadorSql.Fill(pedidosTabla);//el metodo FILL nos permite rellenar el dataTable

                Pedidos.DisplayMemberPath = "INFORMACION";//especificamos de la tabla cual es el campo que queremos ver 
                Pedidos.SelectedValuePath = "Id";//especificamos el campo clave de la tabla
                Pedidos.ItemsSource = pedidosTabla.DefaultView;// especificamos de donde viene la información 
            }

        }

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Haz echo click en un cliente");
            MuestraPedido();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Haz pulsado el boton borrar");
            //MessageBox.Show(Pedidos.SelectedValue.ToString());

            
            string consulta = "DELETE FROM Pedido WHERE Id=@PEDIDOID";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);


            //debemos abrir la conexion a la base de datos 
            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@PEDIDOID", Pedidos.SelectedValue);
            //Los parametros son nombre que le dimos en la consulta y tomamos el nombre del texBox punto selectedValue

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            PedidosTodos();  //Llamamos a este metodo para refrescar la pantalla ya que esta no refesca sola 


        }
    }
}
