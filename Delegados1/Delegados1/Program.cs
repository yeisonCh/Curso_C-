using System;

namespace Delegados1
{
    class Program
    {
        static void Main(string[] args)
        {
            //el delegado debe ser del mismo tipo y los mismos oargumentos o la misma estructura


            //creamos el objeto delegado apuntando al mensaje bienvenida
            ObjetoDelegado saludo = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenido);

            //Utilizamos el delegado para llamar el metodo saludoBienvenida
            saludo("hola amigos");

            ObjetoDel saludoDesp = new ObjetoDel(MensajeDespedida.SaludoDespedida);

            saludoDesp();
        }

        //Definición del objeto delegado

        delegate void ObjetoDelegado(string msj);

        //delegados sin paramtros
        delegate void ObjetoDel();
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenido(string msj)
        {
            Console.WriteLine("Mensaje de bienvenida {0} ", msj);
        }

    }

    class MensajeDespedida
    {
        public static void SaludoDespedida()
        {
            Console.WriteLine("Hola ya nme marcho. Hasta luego ");
        }

    }
}
