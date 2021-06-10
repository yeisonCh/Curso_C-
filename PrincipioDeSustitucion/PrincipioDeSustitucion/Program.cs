using System;

namespace PrincipioDeSustitucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo unCaballo = new Caballo("Babieca");
            Humano unHumano = new Humano("Andres");
            Gorila unGorila = new Gorila("Copito");

            //Console.WriteLine("este es un llamado a la clase Gorila ");
            //unGorila.getNombre();
            //unGorila.respirar();
            //unGorila.cuidarCrias();
            //unGorila.trepar();
            //unHumano.getNombre();
            //unCaballo.getNombre();

            //---------------- PRINCIPIO DE SUSTITUCION------------------------

            Mamiferos animal = new Caballo("Bucéfalo");// la variable animal es un objeto de tipo mamifero 
            Mamiferos persona = new Humano("Sandra"); // persona es un objeto de tipo mamifero 
            //-----ESTOS OBJETOS SOLO PUEDEN ACCEDER A LOS METODOS DE LA CLASE MAMIFEROS------

            Caballo Bucefalo = new Caballo("Bucéfalo");

            animal = Bucefalo;
            object unAnimal = new Caballo("Poni");

            animal.getNombre();

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = unCaballo;
            almacenAnimales[1] = unHumano;
            almacenAnimales[2] = unGorila;

            Console.WriteLine("-----recorremos el array--------");
            for (int i=0; i < 3; i++)
            {
                almacenAnimales[i].getNombre();
                almacenAnimales[i].pensar();
            }



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

        public virtual void pensar()//la palabra reservada virtual  que nos indica que las clases que hereden de esta clase 
            //deben tener este metodo pero la debo modificar a la conveniencia de cada clase 
        {
            Console.WriteLine("pensamiento básico instintivo");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Este meto pertenece a la clase MAMIFEROS");
            Console.WriteLine("es capaz de cuidar las crias hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del servivo es " + nombreServivo);
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
        public override void pensar()//la palabra override es una sobre escritura del metodo pensar de la calse padre
        {
            Console.WriteLine("Este meto pertenece a la clase HUMANO");
            Console.WriteLine("El humano es capaz de pensar  ¿? de la clase Humano");
        }
    }

    class Gorila : Mamiferos
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

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado, de la clase gorila");
        }
    }
}
