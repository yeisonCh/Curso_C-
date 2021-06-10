using System;

namespace UsoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // uso de Switch en C# ..

            Console.WriteLine("Elige medio de transporte (coche, tren, avion)");

            string medioTrans = Console.ReadLine();

            switch (medioTrans)
            {
                case "coche":
                    Console.WriteLine("Velocidad media 100 K/h");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad media 200 K/H");
                    break;
                case "avion":
                    Console.WriteLine("Velocidad media 800 K/H");
                    break;

                default: // se usa como un else con el cual informariamos que lo que se escribio no coincide con las opciones
                    Console.WriteLine("Transporte no contemplado");
                    break;

             
            }
            Console.WriteLine("ha terminado el programa");

            Console.WriteLine("Introduce el numero de mes para cálculo de la comisión");

            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                    
                    Console.WriteLine("mes seleccionado Enero la comisión es de ");
                    break;

                case 2:
                    
                    Console.WriteLine("mes seleccionado Febrero ");
                    break;

                case 3:
                    Console.WriteLine("mes seleccionado Marzo ");
                    break;

                case 4:
                    Console.WriteLine("mes seleccionado Abril");
                    break;

                case 5:
                    Console.WriteLine("mes seleccionado Mayo");
                    break;

                case 6:
                    Console.WriteLine("mes seleccionado Junio");
                    break;

                case 7:
                    Console.WriteLine("mes seleccionado Julio");
                    break;

                case 8:
                    Console.WriteLine("mes seleccionado Agosto");
                    break;
                case 9:
                    Console.WriteLine("mes seleccionado Septiembre");
                    break;
                case 10:
                    Console.WriteLine("mes seleccionado Octubre");
                    break;
                case 11:
                    Console.WriteLine("mes seleccionado Noviembre");
                    break;
                case 12:
                    Console.WriteLine("mes seleccionado Diciembre");
                    break;
                default:
                    Console.WriteLine("numero de mes incorrecto");
                    break;

            }
        }
    }
}
