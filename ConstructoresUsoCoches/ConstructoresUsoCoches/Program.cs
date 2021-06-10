using System;

namespace ConstructoresUsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); //creamos objeto o instancia de tipo Coche ; 
            //le damos un estado inicial a nuestro coche

            Coche coche2 = new Coche();

            Console.WriteLine("el coche numero 2 tiene: " + coche2.getRuedas() + " ruedas");

            //para usar los constructores debemos crear un objeto e instanciarlo y hacer uso no dentro de los parentesis del respectivo constructor

            Coche coche3 = new Coche(2345.54, 1023.21);

            Console.WriteLine(coche1.getInformación());
            coche1.setExtras(true, "Cuero");
            Console.WriteLine(coche1.getExtras());
            Console.WriteLine(coche2.getInformación());
            Console.WriteLine(coche2.getExtras());

            Console.WriteLine("Estamos haciendo uso de la sobrecarga de constructores con el objeto coche3:\n" + coche3.getInformación());
        }
    }

    class Coche
    {
        //Metodo constructor
        public Coche()
        {
            // programamos el estado inicial

            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";
        }

        //sobre carga de constructores 

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
        
        // metodos de acceso o metodo GETTERS
        
        public int getRuedas()
        {
            return ruedas;
        }
        public String getInformación()
        {
            return "Información del coche:\n"+ "Ruedas: "+ ruedas + "\nLargo: " + largo + "\nAncho: " +ancho + "\n"; 

        }

        //metosdos SETTERS  nos sirve para establecer parametros 
        //el objetivo de este metodo es establecer información o dar valor a las propiedades 
        //los metodos que no devuelven nadad son siempre es de tipo VOID
        public void setExtras(bool paramClimatizador, String tapiceria)
        {
            //campode clase = parametro
            climatizador = paramClimatizador; //le indicamos que lo que le pasamos por medio de paramClimatizador se almacene en climatizador
            this.tapiceria = tapiceria;

        }
        //normalmente un metodo seter va acompañado por su respectivo metodo geter 

        //metdo GETTER para el metodo setter extras 

        public String getExtras()
        {

            return "Extras del coche: \n" + "Tapiceria: " + tapiceria + "\nClimatizador: " + climatizador + "\n";
        }

        //propideades (Variables o constantes)
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;

    }
}
