using System;

namespace condicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            bool haceFrio = false;

            Console.WriteLine(!haceFrio);

            int edad = 15;

            Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            

            //operador ! el cual nos sirve para negar o negacion 

            // OPERADORES DE COMPARACIÓN
            
            //== igual que 
            //!= diferente que 
            //< menor que 
            //> mayor que 
            //<= menor o igual que 
            //>= mayor o igual que 

            //OPERADORES LOGICOS 

            // && y logico 
            // || ó logico 


            if (edad >= 18)
            {
                Console.WriteLine("esres mayor de edad ");
            }
            Console.WriteLine("No eres mayor de edad =(");
        }
    }
}
