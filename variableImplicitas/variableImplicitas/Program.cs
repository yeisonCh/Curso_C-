using System;

namespace variableImplicitas
{
    class Program
    {
        static void Main(string[] args)
        {
            int eadadPersona1;
            int eadadPersona2;
            int eadadPersona3;
            int eadadPersona4;
            eadadPersona1 = eadadPersona2 = eadadPersona3 = eadadPersona4 = 27;//iniciamos todas las variables en una sola linea

            Console.WriteLine(eadadPersona3);



            double temperatura = 34.5;

            int temperaturaMadrid;

            //conversion explicita o casting

            temperaturaMadrid = (int)temperatura;//con un parenticis hacemos el cambio o casing  de double a entero

            Console.WriteLine(temperatura);
            Console.WriteLine(temperaturaMadrid);

            //conversion implicita

            int habitantesCiudad = 10000000;

            long habitantesCiudad2018 = habitantesCiudad;

            float pesoMaterial = 5.78F;//Una variable de tipo float debe llevar siemple el subfijo F

            double pesoMaterialPrec = pesoMaterial;

            Console.WriteLine(habitantesCiudad);
            Console.WriteLine(habitantesCiudad2018);
            Console.WriteLine(pesoMaterial);
            Console.WriteLine(pesoMaterialPrec);

        }
    }
}
