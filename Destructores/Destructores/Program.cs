using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ManejoArchivo miArchivo = new ManejoArchivo();

            miArchivo.mensaje();
        }
    }
    class ManejoArchivo
    {
        StreamReader archivo = null;//es un objeto de tipo StreamReader
        int contador = 0;
        string linea;

        public ManejoArchivo()
        {
            archivo = new StreamReader(@"C:\texto.txt");
            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);

                contador++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine("hay {0} lineas ",contador);
        }

        ~ManejoArchivo()//el destructor debe llamarce igual al constructor
        {
            archivo.Close();
        }

    }
}
