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

namespace CRUD_LING
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creamos el dataContex un objeto de tipo(nombre del archivo linq que hemos creado) seguido del nombre que queremos en este caso dataContex 
        DataClasses1DataContext dataContex;
        public MainWindow()
        {
            InitializeComponent();

            // debemos ir en la parte derecha en nuetro proyecto dar click derecho a referencias
            //agregar referencia, agregamos System.Configuration 
            // y debemos utilisar el namespace using System.Configuration

            string miConexion = ConfigurationManager.ConnectionStrings["CRUD_LING.Properties.Settings.CrudLinqSql"].ConnectionString;
            // dentro de los corchetes se coloca el nombre del proyecto. Properties. settings. nombre de la cadena de conexion con la base de datos

            //creamos el dataContex funciona como proxy nos sirve para acceder a nuestro origen de datos

            //como usamos LINQ damos click derecho sobre la raiz de nuestro proyecto
            //le damos agregar nuevo elemento  y agregamos un archivo con extención dbml
            // esto nos servira para hacer un mapeo de nuestra base de datos
            // en el buscador le damos linq y seleccionamos clase de linq to Sql

            // establecemos la conexión con el archivo LINQ  que hemos creado 

            //esto lo hacemos instanciando la clase o el objeto datContex y como parametro la conexion
            dataContex = new DataClasses1DataContext(miConexion);

            //InsertaEmpresas();
            //InsertaEmpleado();
            //InsertaCargos();
            InsertaCargoEmpleado();

        }

        //creamos un metodo que nos permita insertar empresas 
        public void InsertaEmpresas()
        {
            //dataContex.ExecuteCommand("delete from empresa");//le decimos a datContex que nos ejecute un comando SQL que es borar de la tabla empresa

            Empresa pildorasInformaticas = new Empresa();

            pildorasInformaticas.Nombre = "Pildoras Informaticas";
            //debemos dar el comando para que inserte la empresa
            dataContex.Empresa.InsertOnSubmit(pildorasInformaticas); //para que el dataContex inserte la informacion 


            Empresa empresaGoogle = new Empresa();

            empresaGoogle.Nombre = "google";
            
            dataContex.Empresa.InsertOnSubmit(empresaGoogle);


            dataContex.SubmitChanges(); //instruccion para que el dataContex tome efecto

            //tomamos el nombre del dataGrid de la aplicacion grafica 

            Principal.ItemsSource = dataContex.Empresa;


        }


        public void InsertaEmpleado()
        {

            //Empresa pildorasInformaticas = dataContex.Empresa.First("from Empresa in dataContex.Empresa where Nombre == 'Pildoras Informaticas' select Empresa");
            Empresa pildorasInformaticas = dataContex.Empresa.First(em => em.Nombre.Equals("Pildoras informaticas"));
            //creamos una variable em y le decimos que em.nombre que es la propidad en la tabla, sea igual al no mbre de la empresa que queremos buscar
            Empresa empresaGoogle = dataContex.Empresa.First(em => em.Nombre.Equals("google"));

            // creamos una lista  para guardar mas de un empleado 

            List<Empleado> listaEmpleados = new List<Empleado>();

            //agregar empleado 

            listaEmpleados.Add(new Empleado { Nombre = "Juan", Apellido = "Diaz", EmpresaId=pildorasInformaticas.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Alejandro", Apellido = "Chaparro", EmpresaId = pildorasInformaticas.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Ana", Apellido = "Martinez", EmpresaId = empresaGoogle.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Gabriel", Apellido = "Nuñez", EmpresaId = empresaGoogle.Id });

            dataContex.Empleado.InsertAllOnSubmit(listaEmpleados);

            dataContex.SubmitChanges();

            Principal.ItemsSource = dataContex.Empleado;

        }

        public void InsertaCargos()
        {
            Cargo director = new Cargo();

            director.NombreCargo = "Director";
            dataContex.Cargo.InsertOnSubmit(director);

            dataContex.Cargo.InsertOnSubmit(new Cargo { NombreCargo= "Administrativo/a"});
           
            dataContex.SubmitChanges();

            Principal.ItemsSource = dataContex.Cargo;

        }

        public void InsertaCargoEmpleado()
        {
            Empleado juan = dataContex.Empleado.First(empl => empl.Nombre.Equals("Juan"));
            Empleado alejo = dataContex.Empleado.First(empl => empl.Nombre.Equals("Alejandro"));

            Cargo dir = dataContex.Cargo.First(ca => ca.NombreCargo.Equals("Director"));
            Cargo Adm = dataContex.Cargo.First(ca => ca.NombreCargo.Equals("Administrativo/a"));


            CargoEmpleado cargoJuan = new CargoEmpleado();
            cargoJuan.Empleado = juan;
            cargoJuan.Cargo = dir;

            //dataContex.CargoEmpleado.InsertOnSubmit(cargoJuan);
            dataContex.SubmitChanges();

            Principal.ItemsSource = dataContex.CargoEmpleado;

            CargoEmpleado cargoAle = new CargoEmpleado();
            cargoAle.Empleado = alejo;
            cargoAle.Cargo = Adm;

        }
    }
}
