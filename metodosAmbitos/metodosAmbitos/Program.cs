using System;

namespace metodosAmbitos
{
    class Program
    {
        //declaración de variables como ambito de clase 
        //tambien llamados campos de clase
        int numero1 = 5;
        int numero2 = 7;

       

        static void Main(string[] args)
        {
            Console.WriteLine(suma(5.3, 4));
        }

        void primerMetodo()
        {
           
            Console.WriteLine(numero1+numero2);

        }
        void segundoMetodo()
        {
            Console.WriteLine(numero1+numero2);
        }

        //SOBRE CARGA DE METODOS
        //para esto los metodos tienen el mismo nombre pero tienen diferente cantidad de parametros 
        //o diferente tipo de parametros 
        static int suma(int operador1, int operador2) => operador1 + operador2;

        static int suma(int numero1, int numero2, int numero3) => numero1 + numero2;

        static double suma(double operador1, int operador2) => operador1 + operador2;

    }
}
