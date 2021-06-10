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

namespace GestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //cadena de conexion
            //estable la conexión con la base de datos 
            string miConexion = ConfigurationManager.ConnectionStrings["GestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            //establece la conexion sql
            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();
            MuestraTodosPedidos();
            
        }

        private void MuestraClientes()
        {
            try
            {
                string consulta = "select * from cliente";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)// debemos usar un adaptador 
                {
                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(clientesTabla);

                    listClientes.DisplayMemberPath = "nombre";// especificamos de la tabla el campo que queremos 
                    listClientes.SelectedValuePath = "Id";// especificamos el campo clave de la tabla
                    listClientes.ItemsSource = clientesTabla.DefaultView;//especificamod de donde viene la información 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        
        private void MuestraPedidos()
        {
            try
            {
                string consulta = "select * from pedido P INNER JOIN cliente C on C.Id=P.cCliente " +
                    " where C.Id=@clienteId";


                //para hacer una consulta parametrica debemos manejar SqlCommand
                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);



                using (miAdaptadorSql)// debemos usar un adaptador 
                {
                    sqlComando.Parameters.AddWithValue("@clienteId", listClientes.SelectedValue);

                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);

                    listPedidos.DisplayMemberPath = "fechaPedido";// especificamos de la tabla el campo que queremos 
                    listPedidos.SelectedValuePath = "Id";// especificamos el campo clave de la tabla
                    listPedidos.ItemsSource = pedidosTabla.DefaultView;//especificamod de donde viene la información 
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString()); //el objeto e pasado a string
            }
        }

        private void MuestraTodosPedidos()
        {
            try
            {
                string consulta = "select *, concat(cCliente, ' ', fechaPedido, '', formaPago) as infoCompleta from pedido";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);  //con esta instrucción tenemos cardado en memoria la información de nuestra consulta
                    todosPedidos.DisplayMemberPath = "infoCompleta";
                    todosPedidos.SelectedValuePath = "Id";
                    todosPedidos.ItemsSource = pedidosTabla.DefaultView;
                }


            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        SqlConnection miConexionSql;

        /*private void listClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            MuestraPedidos();
            
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(todosPedidos.SelectedValue.ToString());

            string consulta = "delete from pedido where id=@pedidoid ";

            SqlCommand miSqlComand = new SqlCommand(consulta, miConexionSql);
            //abrir la conexion sql 
            miConexionSql.Open();

            miSqlComand.Parameters.AddWithValue("@pedidoid", todosPedidos.SelectedValue);

            //ejecutamos la cosnulta 

            miSqlComand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraTodosPedidos();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(todosPedidos.SelectedValue.ToString());

            string consulta = "insert into cliente (nombre) values (@nombre)  ";

            SqlCommand miSqlComand = new SqlCommand(consulta, miConexionSql);
            //abrir la conexion sql 
            miConexionSql.Open();

            //la siguiente instrucción nos dice que el parametro @nombre se toma del cuadro con nombre insertaCliente y se rescata el texto que esta alli dentro
            miSqlComand.Parameters.AddWithValue("@nombre", insertaCliente.Text);

            //ejecutamos la cosnulta 

            miSqlComand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();

            insertaCliente.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(todosPedidos.SelectedValue.ToString());

            string consulta = "delete from cliente where id=@clienteid ";

            SqlCommand miSqlComand = new SqlCommand(consulta, miConexionSql);
            //abrir la conexion sql 
            miConexionSql.Open();

            miSqlComand.Parameters.AddWithValue("@clienteid", listClientes.SelectedValue);

            //ejecutamos la cosnulta 

            miSqlComand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();
        }

        private void listClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //instanciamos la ventana nueva que hemos creado
            Actualiza ventanaActualizar = new Actualiza((int)listClientes.SelectedValue);


            //tenemos otro metodo que es ShowDialog() que es una ventana modal y detiene el flujo de ejecución

             ventanaActualizar.Show(); 
            //mostramos en una ventana emergente la ventana (ventanaActualizar)

            try
            {
                string consulta = "select nombre from cliente where id=@Clid";

                SqlCommand miSqlComand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(miSqlComand);

                using (miAdaptadorSql)// debemos usar un adaptador 
                {
                    miSqlComand.Parameters.AddWithValue("@Clid", listClientes.SelectedValue);

                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(clientesTabla);

                    ventanaActualizar.cuadroActualiza.Text= clientesTabla.Rows[0]["nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            /* PRIMERA SOLUCIÓN
             *
            ventanaActualizar.ShowDialog();
            MuestraClientes();
            */
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            MuestraClientes();
        }
    }
}
