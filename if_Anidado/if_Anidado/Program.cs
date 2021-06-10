using System;

namespace if_Anidado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Introduce tu edad, por favor");

            int edad = Int32.Parse(Console.ReadLine());
            if (edad < 18) Console.WriteLine("Tienes carnet "); 

            else
            {
                Console.WriteLine("¿ Tienes Carnet ?");

                string carnet = Console.ReadLine();

                //esta linea compara una cadena de caracteres con tres parametros y nos debuelve 0 para verdadero y 1 para falso
                //primer parametro es la cadena a comparar 
                //segundo parametro es con que queremos comparar la cadena 
                //tercer parametro true para ignorar mayusculas o minusculas en las cadenas a comparar 
                int compara = String.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir vehiculo");

                else Console.WriteLine("No puedes conducir un vehiculo");
            }
            
        }
    }
}
