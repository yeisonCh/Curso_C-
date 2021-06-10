using System;

namespace if_anidados_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la nota del primer parcial");

            double parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota del segundo parcial");
            
            double parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota del tercer parcial");

            double parcial3 = Int32.Parse(Console.ReadLine());

            //Operador logico ó 
            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5) Console.WriteLine("La nota media es "+ (parcial1+parcial2+parcial3)/3);

            else Console.WriteLine("Vuelve en septiembre");
        }
    }
}
