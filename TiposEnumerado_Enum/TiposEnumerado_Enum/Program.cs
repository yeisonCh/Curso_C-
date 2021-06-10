using System;

namespace TiposEnumerado_Enum
{
    //LOS TIPOS ENUMERADOS ESTAN CASI SIEMPRE EN EL NAMESPACE
    class Program
    {
        static void Main(string[] args)
        {
            Estaciones alergia = Estaciones.Primavera;

            String la_alergia = alergia.ToString();// la palabra ToString no pasa el valor de una variable a string

            Console.WriteLine(alergia);

            //para guardar el valor nulo en un tipo enumerado
            //Estaciones? alergia = null;

            //-------------------------------------------------------------

            Bonus antonio = Bonus.bueno;

            Console.WriteLine(antonio);//pero esta instrucción me imprime el nombre de la variable como tal en este caso "Bueno"
            //para que nos imprima el valor debemos hacer un casting 

            double bonusAntonio = (double)antonio;//con esta instrucción se hace un casting en este caso a double

            Console.WriteLine(bonusAntonio);

            double salarioAntonio = 1500 + bonusAntonio;
            Console.WriteLine(salarioAntonio);
        }
    }

    enum Estaciones { Primavera, Verano, Otoño, Invierno};//no son string son xonstantes 

    enum Bonus {bajo=500, normal=1000, bueno=1500, extra=3000};//le podemos dar un valor a cada variable que hemos declarado
}
