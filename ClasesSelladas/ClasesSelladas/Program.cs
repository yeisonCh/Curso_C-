using System;

namespace ClasesSelladas //LA CALSE ES AQUELLA DE LA CUAL NO SE PUEDE HEREDAR
    //EN LOS METODOS TAMBIEN PODEMOS REALIZAR METODOS SELLADOS QUE IMPIDEN SOBRE ESCRIBIR EN LAS CLASES QUE HEREDEN DE ESTE 
    //ESTO IMPIDE LA HERENCIA Y LA SOBRE ESCRITURA DE METODOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Lagartija Juancho = new Lagartija("Juancho");

            Juancho.Respirar();
            Juancho.GetNombre();

            Humano Juan = new Humano("Juan");

            Juan.GetNombre();
            Juan.Respirar();

            Caballo pony = new Caballo("Pony");
            pony.GetNombre();
            pony.Respirar();
        }
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();//este es un metodo de una interface no llevan modificador de acceso

    }


    interface IAnimalesYDeportes
    {
        string TipoDeporte();
        Boolean EsOlimpico();
    }

    interface ISaltoConPatas
    {
        int NumeroPatas();
    }

    //creando clases abstractas
    abstract class Animales
    {
        public void Respirar()
        {
            //Console.WriteLine("Este meto pertenece a la clase MAMIFEROS");
            Console.WriteLine("Es capaz de repirar ");
        }

        public abstract void GetNombre();
    }
    class Mamiferos : Animales
    {

        private string nombreServivo; //campo de clase 

        //creamos un constructor 
        public Mamiferos(String nombreServivo)
        {
            this.nombreServivo = nombreServivo;
        }

        public void CuidarCrias()//el nombre de los metodos siempre inician con mayusculas
        {
            Console.WriteLine("Este meto pertenece a la clase MAMIFEROS");
            Console.WriteLine("es capaz de cuidar las crias hasta que se valgan por si solas");
        }

        public override void GetNombre()
        {
            Console.WriteLine("El nombre del ser vivo es " + nombreServivo);
        }


    }

    class Lagartija : Animales
    {
        public Lagartija(string nombreReptil)
        {
            this.nombreReptil = nombreReptil;
        }

        public override void GetNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + nombreReptil);
        }

        private string nombreReptil;
    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }
        public void Nadar()
        {
            Console.WriteLine("La ballena es capaz de nadar");
        }

    }
    //para implementar una interfaz se colocan despues d elas clases que herede
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {

        public Caballo(String nombreCaballo) : base(nombreCaballo) //con la palabra :base llamamos el constructor de la clase padre
        {

        }
        public void Galopar()//metodo propio de la clase 
        {
            Console.WriteLine("Este meto pertenece a la clase Caballo");
            Console.WriteLine("El caballo es capaz de galopar");
        }

        int IMamiferosTerrestres.NumeroPatas()//implementando un  metodo de una interface
        {
            return 4;
        }

        public string TipoDeporte()//implementado un metodo de una interface 
        {
            return "Equitación";
        }

        public Boolean EsOlimpico()//implementando un metodo de una interface 
        {
            return false;
        }

        //Cuando utilizamos la notación de nombre de la interface y punto debemos precindir del modificador de acceso public
        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano) //con la palabra :base llamamos el constructor de la clase padre
        {

        }
        public void Pensar()
        {
            Console.WriteLine("Este meto pertenece a la clase HUMANO");
            Console.WriteLine("El humano es capaz de pensar  ¿? ");
        }
    }


    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        //si construimos un constructor en la clase padre, debemos construir la instrucción base
        public Gorila(String nombreGorila) : base(nombreGorila) //con la palabra :base llamamos el constructor de la clase padre
        {

        }
        public void Trepar()
        {
            Console.WriteLine("Este meto pertenece a la clase GORILA");
            Console.WriteLine("El gorila es capaz de trepar");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }

    class Chimpace : Gorila
    {
        public Chimpace(string nombreChimpace) : base(nombreChimpace) 
        { 
        
        }
    }
}
