using System;

namespace Properties_
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado juan = new Empleado("Juan");

            juan.SALARIO = 1500;

            Console.WriteLine("El empleado tiene un salario de: "+juan.SALARIO);

            juan.SALARIO += 200;
            Console.WriteLine("El empleado tiene un nuevo salario de: "+ juan.SALARIO);

            juan.SALARIO = -400;
            Console.WriteLine("El salario del empleado es: "+ juan.SALARIO);


        }
    }
    class Empleado
    {
        public Empleado(string nombre)
        {
            this._nombre = nombre;
        }

       /* public void SetSalario(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("EL salario no puede ser nagativo, Se asignara 0 como salario");
                this.salario = 0;
            }
            else this.salario = salario;

        }

        public double GetSalario()
        {
            return salario;
        }*/

        //creación de metodos usando properties

        private double EvaluaSalario(double salario)
        {
            if (salario < 0) return 0;

            else return salario;
        }

        //CREACIÓN DE PROPIEDAD  

        /*public double SALARIO
        {
            get { return this.salario; }
            set { this.salario = EvaluaSalario(value); }
        }*/

        //el codigo anterior lo podemos soimplificar asi:

        public double SALARIO
        {
            get => this._salario;

            set => this._salario = EvaluaSalario(value);

        }

        private string _nombre;  //cuando se usa n propiedades se suele utlilizar el nombre de campo con un guion al piso _nombre
        private double _salario;
    }
}
