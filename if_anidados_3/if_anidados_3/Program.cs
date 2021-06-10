using System;

namespace if_anidados_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad");

            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres un niño");

            else if (edad < 30) Console.WriteLine("Eres un Joven");

            else if (edad < 60) Console.WriteLine("Eres maduro");

            else Console.WriteLine("debes cuidarte ya");
        }
    }
}
