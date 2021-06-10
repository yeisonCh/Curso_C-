using System;

namespace excepcionesConThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.MaxValue;
            int resultado = unchecked(numero + 20);//unchecked nos ayuda para saltarnos la exepción por desbordamiento
            // checked y unchecked solo funcionan con datos int y long 

            Console.WriteLine(resultado);
        }
    }
}
