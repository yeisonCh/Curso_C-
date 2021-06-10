using System;

namespace Expresiones_Lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona P1 = new Persona();
            P1.Nombre = "Jua";
            P1.Edad = 18;

            Persona P2 = new Persona();
            P2.Nombre = "Jua";
            P2.Edad = 34;

            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

            ComparaNombre ComparaNombre = (nom1, nom2) => nom1 == nom2;

            Console.WriteLine(comparaEdad(P1.Edad, P2.Edad));

            Console.WriteLine(ComparaNombre(P1.Nombre, P2.Nombre));
        }

        //creamos un delegado para comparar edades 
        public delegate bool ComparaPersonas(int edad1, int edad2);

        public delegate bool ComparaNombre(string per1, string per2);

    }

    class Persona
    {


        private string nombre;
        private int edad;

        //metodos Geter y Seter para las variables creadas
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
