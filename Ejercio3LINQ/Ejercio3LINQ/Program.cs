using System;
using System.Linq;
using System.Collections.Generic;

namespace Ejercio3LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNumero;

            //instanciamos la clase controlEmpresasEmpleados 

            ControlEmpresasEmpleados consulta = new ControlEmpresasEmpleados();

            //consulta.getProgramador();

            consulta.getEmpleadosOrdenados();

            Console.WriteLine("------------------- Ordenados por nombre de forma descendente -----------------------------");

            consulta.getEmpleadosOrdenadosDes();

            Console.WriteLine("------------------- consulta por empresa Pildoras -----------------------------");

            consulta.getEmpresaPildoras();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------- consulta por empleado por empresa -----------------------------" +"\n");
            Console.WriteLine("para empleados de google digita 1 para empleados de pildoras digita 2"+"\n");

            try
            {
                idNumero = Int32.Parse(Console.ReadLine());

                consulta.getEmpleadosEmpresa(idNumero);

            }
            catch
            {
                Console.WriteLine("Haz introducido un Id erroneo");
            }
            
        }


    }

    class ControlEmpresasEmpleados
    {
        //constructor 

        public ControlEmpresasEmpleados()
        {
            listaEmpresa = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            // agregando datos a las listas 

            listaEmpresa.Add(new Empresa { Id = 1, Nombre = "google" });
            listaEmpresa.Add(new Empresa { Id = 2, Nombre = "Pildoras Informaticas" });

            listaEmpleados.Add(new Empleado
            {
                Id = 1,
                Nombre = "Andres Chaparro",
                Cargo = "programador",
                EmpresaId = 1,
                Salario = 2300000
            });

            listaEmpleados.Add(new Empleado
            {
                Id = 2,
                Nombre = "Josue Nuñez",
                Cargo = "Desarrollador",
                EmpresaId = 2,
                Salario = 3900000
            });

            listaEmpleados.Add(new Empleado
            {
                Id = 3,
                Nombre = "Andres Chaparro",
                Cargo = "CEO",
                EmpresaId = 1,
                Salario = 31300000
            });

            listaEmpleados.Add(new Empleado
            {
                Id = 4,
                Nombre = "Sandra Nuñez",
                Cargo = "SubGerente",
                EmpresaId = 2,
                Salario = 6300000
            });


        }

        // uso de LINQ para obter datos de objetos 

        public void getProgramador()
        {
            IEnumerable<Empleado> programador = from Empleado in listaEmpleados where Empleado.Cargo == "programador" select Empleado;

            foreach (Empleado empleado in programador)
            {
                empleado.getDatosEmpleado();

            }
        }

        public void getEmpleadosOrdenados()
        {
            //ordenados por nombre de forma acendente 
            IEnumerable<Empleado> empleados = from Empleado in listaEmpleados orderby Empleado.Nombre select Empleado;

            foreach (Empleado empleado in empleados)
            {
                empleado.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenadosDes()
        {
            //ordenados por nombre de forma acendente 
            IEnumerable<Empleado> empleados = from Empleado in listaEmpleados orderby Empleado.Nombre descending select Empleado;

            foreach (Empleado empleado in empleados)
            {
                empleado.getDatosEmpleado();
            }
        }

        // consulta para usarlos con ambos objetos o ambas listas 

        public void getEmpresaPildoras()
        {
            //ordenados por nombre de forma acendente 
            IEnumerable<Empleado> empleados = from Empleado in listaEmpleados join Empresa in listaEmpresa on 
                                              Empleado.EmpresaId equals Empresa.Id 
                                              where Empresa.Nombre== "Pildoras Informaticas"
                                              select Empleado;

            foreach (Empleado empleado in empleados)
            {
                empleado.getDatosEmpleado();
            }
        }


        public void getEmpleadosEmpresa(int IdEmpresa)
        {
            //ordenados por nombre de forma acendente 
            IEnumerable<Empleado> empleados = from Empleado in listaEmpleados
                                              join Empresa in listaEmpresa on
              Empleado.EmpresaId equals Empresa.Id
                                              where Empresa.Id==IdEmpresa
                                              select Empleado;

            foreach (Empleado empleado in empleados)
            {
                empleado.getDatosEmpleado();
            }
        }

        public List<Empresa> listaEmpresa;
        public List<Empleado> listaEmpleados;
    }

    class Empresa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa: {0} con Id {1}", Nombre, Id);
        }
    }

    class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public double Salario { get; set; }

        //clave foránea
        public int EmpresaId { get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado: {0} con Id {1}, cargo  {2} con salario {3} y pertenece a la empresa {4}" +
                " ", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }
}
