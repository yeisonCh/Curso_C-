using System;
using System.Collections.Generic;
using System.Linq;

namespace objetosConLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos la clase controlEmpresasEmpleados 

            ControlEmpresasEmpleados consulta = new ControlEmpresasEmpleados();

            consulta.getProgramador();
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
            listaEmpresa.Add(new Empresa {Id = 2, Nombre="Pildoras Informaticas" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Andres Chaparro",
                Cargo = "programador", EmpresaId = 1, Salario = 2300000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Josue Nuñez",
                Cargo = "Desarrollador", EmpresaId = 2, Salario = 3900000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Andres Chaparro",
                Cargo = "CEO", EmpresaId = 1, Salario =31300000 });
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
                empleado.getDatosEmpleadp();
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

        public void getDatosEmpleadp()
        {
            Console.WriteLine("Empleado: {0} con Id {1}, cargo  {2} con salario {3} y pertenece a la empresa {4}" +
                " ", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }

}
