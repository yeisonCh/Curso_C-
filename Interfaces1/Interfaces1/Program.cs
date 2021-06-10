using System;

namespace Interfaces1
{
    class Program
    {   
        static void Main(string[] args)
        {
            Caballo unCaballo = new Caballo("Babieca");
            Humano unHumano = new Humano("Andres");
            Gorila unGorila = new Gorila("Copito");

            //hacemos el principio de sustitución para usar el metodo numero de patas 
            ISaltoConPatas IUncaballo = unCaballo;
            IMamiferosTerrestres iUncaballo = unCaballo;


            Console.WriteLine("este es un llamado a la clase Gorila ");
            unGorila.GetNombre();
            unGorila.Respirar();
            unGorila.CuidarCrias();
            
            Console.WriteLine("el gorila tiene: " + unGorila.NumeroPatas()+ " patas");
            unGorila.Trepar();
            unHumano.GetNombre();
            unCaballo.GetNombre();

            Console.WriteLine("este es un llamado a la clase caballo ");
            unCaballo.GetNombre();
            unCaballo.Respirar();
            unCaballo.CuidarCrias();
            Console.WriteLine("el el caballo tiene: " + iUncaballo.NumeroPatas() + " patas");
            Console.WriteLine("el el caballo salta con: " + IUncaballo.NumeroPatas() + " patas");

        }
    }
    //creando una interface
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
    class Mamiferos
    {
        private string nombreServivo; //campo de clase 
        
        //creamos un constructor 
        public Mamiferos(String nombreServivo)
        {
            this.nombreServivo = nombreServivo;
        }
        public void Respirar()
        {
            Console.WriteLine("Este meto pertenece a la clase MAMIFEROS");
            Console.WriteLine("Es capaz de repirar ");
        }

        public void CuidarCrias()//el nombre de los metodos siempre inician con mayusculas
        {
            Console.WriteLine("Este meto pertenece a la clase MAMIFEROS");
            Console.WriteLine("es capaz de cuidar las crias hasta que se valgan por si solas");
        }

        public void GetNombre()
        {
            Console.WriteLine("El nombre del servivo es " + nombreServivo);
        }

       
    }

    class Ballena : Mamiferos
    {
        public Ballena (String nombreBallena) : base(nombreBallena)
        {

        }
        public void Nadar()
        {
            Console.WriteLine("La ballena es capaz de nadar");
        }

    }
    //para implementar una interfaz se colocan despues d elas clases que herede
    class Caballo : Mamiferos,IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas 
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

    class Gorila : Mamiferos,IMamiferosTerrestres
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

        //AL INPMENETAR UN METODO DE UNA INTERFACE SE DEBE 
        //el nombre debe ser igual al que se escribio en la interface
        //el numero de parametros debe ser el mismo 
        //el tipo de dato que debuelve deb ser el mismo
        public int NumeroPatas()
        {
            return 2;
        }
    }
}
