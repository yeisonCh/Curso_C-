using System;

namespace EjemploEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado(Bonus.extras, 190.50);
            Console.WriteLine("Elsalario del empleaado es: " + Juan.GetSalario());
        }
    }

    class Empleado
    {
        //podemos trabajar con tipos enumerados como parametros
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus = (double)bonusEmpleado;//esta instrucción es un casting para pasar de bonus o (enum) a double.
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario + bonus;
        }

        private double salario, bonus;

    }
    enum Bonus { bajo=500, normal=1000, bueno=1500, extras=3000};
}
