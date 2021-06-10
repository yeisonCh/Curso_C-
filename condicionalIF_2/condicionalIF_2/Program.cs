using System;

namespace condicionalIF_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a evaluir si puedes conducir un vehiculo!");

            bool carnet = true;

            if (carnet==true)//podemos omitir el == true, ya que al no tenerlo afirmamos la variable

                Console.WriteLine("Puedes conducir un vehiculo");
            else
                Console.WriteLine("Lo sienti pero no puedes conducir vehiculo");

            Console.WriteLine("Por favor introduce tu edad");

            int edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("¿Tienes carnet?");

            string carne = Console.ReadLine();

            if (edad >= 18 && carne == "si") Console.WriteLine("puedes conducir un vehiculo =)");

            else Console.WriteLine("NO puedes conducir un vehiculo  =( ");

        }
    }
}
