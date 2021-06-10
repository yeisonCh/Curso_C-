using System;

namespace InterfacesEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico aviso1 = new AvisosTrafico();

            aviso1.MostrarAviso();

            AvisosTrafico aviso2 = new AvisosTrafico("secretaria de transito de Boyacá", "Ecceso de velocidas", "02-11-2020");

            Console.WriteLine(aviso2.GetFecha()) ;
            aviso2.MostrarAviso();
        }
    }


}
