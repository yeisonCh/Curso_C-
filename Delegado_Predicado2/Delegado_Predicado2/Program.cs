using System;
using System.Collections.Generic;

namespace Delegado_Predicado2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> gente = new List<Persona>();

            Persona P1 = new Persona();
            P1.Nombre = "Jua";
            P1.Edad = 18;

            Persona P2 = new Persona();
            P2.Nombre = "Andres";
            P2.Edad = 34;

            Persona P3 = new Persona();
            P3.Nombre = "Paola";
            P3.Edad = 28;

            gente.AddRange(new Persona[] { P1, P2, P3 });


            Predicate<Persona> elPredicado = new Predicate<Persona>(ExisteJuan);

            bool existe = gente.Exists(elPredicado);

            if (existe) Console.WriteLine("Hay personas que se llaman Juan ");
            else Console.WriteLine("No hay personas que se llaman juan");



            Console.WriteLine("Hello World!");



        }

        static bool ExisteJuan(Persona persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }
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
