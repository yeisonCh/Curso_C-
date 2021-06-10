using System;

namespace Herencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo unCaballo = new Caballo("Babieca");
            Humano unHumano = new Humano("Andres");
            Gorila unGorila = new Gorila("Copito");

            Console.WriteLine("este es un llamado a la clase Gorila ");
            unGorila.getNombre();
            unGorila.respirar();
            unGorila.cuidarCrias();
            unGorila.trepar();
            unHumano.getNombre();
            unCaballo.getNombre();

        }
    }

    class Mamiferos
    {
        private string nombreServivo; //campo de clase 
        
        //creamos un constructor 
        public Mamiferos(String nombreServivo)
        {
            this.nombreServivo = nombreServivo;
        }
        public void respirar()
        {
            Console.WriteLine("Este meto pertenece a la clase MAMIFEROS");
            Console.WriteLine("Es capaz de repirar ");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Este meto pertenece a la clase MAMIFEROS");
            Console.WriteLine("es capaz de cuidar las crias hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del servivo es "+ nombreServivo);
        }
        
    }

    class Caballo : Mamiferos
    {

        public Caballo(String nombreCaballo) : base(nombreCaballo) //con la palabra :base llamamos el constructor de la clase padre
        {
            
        }
        public void galopar()
        {
            Console.WriteLine("Este meto pertenece a la clase Caballo");
            Console.WriteLine("El caballo es capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano) //con la palabra :base llamamos el constructor de la clase padre
        {

        }
        public void pensar()
        {
            Console.WriteLine("Este meto pertenece a la clase HUMANO");
            Console.WriteLine("El humano es capaz de pensar  ¿? ");
        }
    }

    class Gorila: Mamiferos
    {
        //si construimos un constructor en la clase padre, debemos construir la instrucción base
        public Gorila(String nombreGorila) : base(nombreGorila) //con la palabra :base llamamos el constructor de la clase padre
        {

        }
        public void trepar()
        {
            Console.WriteLine("Este meto pertenece a la clase GORILA");
            Console.WriteLine("El gorila es capaz de trepar");
        }
    }
}
