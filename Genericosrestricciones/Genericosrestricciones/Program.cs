using System;

namespace Genericosrestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleado<Director> empleados = new AlmacenEmpleado<Director>(3);

            empleados.SetAgregar(new Director(230000));
            empleados.SetAgregar(new Director(31000));
            empleados.SetAgregar(new Director(51000));

            AlmacenEmpleado<Secretaria> empleados1 = new AlmacenEmpleado<Secretaria>(3);

            empleados1.SetAgregar(new Secretaria(230000));
            empleados1.SetAgregar(new Secretaria(230000));
            empleados1.SetAgregar(new Secretaria(230000));

            AlmacenEmpleado<Estudiante> estudiante = new AlmacenEmpleado<Estudiante>(2);
                

        }
    }

    //creamos una clase generica con restricciones
    //esta clase solo nos permitira crear objetos donde implemente la interfaz IParaEmpleados
    class AlmacenEmpleado<T> where T : IParaEmpleados
    {
        //creamos un constructor que recibe por parametro un entero que es la cantidad de valores que almacenara el array

        public AlmacenEmpleado(int z)
        {
            //creamos el array con la z cantidad de lementos 
            datosEmpleado = new T[z];
        }

        public void SetAgregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T GetEmpleado(int i)
        {
            return datosEmpleado[i];
        }

        private int i = 0;
        //creamos una variable datosEmpleados de tipo array 
        private T[] datosEmpleado;
    }
    class Director:IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario;
        }
               
        public double GetSalario()
        {
            return salario;
        }

        private double salario;

    }

    class Secretaria:IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }
        public double GetSalario()
        {
            return salario;
        }

        private double salario;
    }

    class Electricista:IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        public double GetSalario()
        {
            return salario;
        }

        private double salario;
    } 

    class Estudiante
    {
        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        private double edad;
    }

    interface IParaEmpleados
    {
        double GetSalario();
    }
}
