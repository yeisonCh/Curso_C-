using System;

namespace ejemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try 
            {
                string linea;

                int contador = 0;

                string path = @"C:\Users\Yeison\Desktop\tirar.txt";

                archivo = new System.IO.StreamReader(path);


                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;
                }


            }
            catch(Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }

            finally
            {
                if (archivo != null) archivo.Close();

                Console.WriteLine("Conexion con el fichero cerrada");
            }
        }
    }
}
