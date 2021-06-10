using System;

namespace EjercicoGuiado1
{
    class Program
    {
        static void Main(string[] args)
        {

            Transporte avion = new Avion();
            Transporte carro = new Coche();
            Transporte bote = new Vehiculo();

            avion.arrancarMotor();
            avion.conducir();
            avion.pararMotor();
            Console.WriteLine("------------------coche-----------------");
            carro.arrancarMotor();
            carro.conducir();
            carro.pararMotor();
            Console.WriteLine("----------- Vehiculo---------------------");
            bote.arrancarMotor();
            bote.conducir();
            bote.pararMotor();

            Transporte[] transporte = new Transporte[3];


            transporte[0] = avion;
            transporte[1] = carro;
            transporte[2] = bote;
            Console.WriteLine("----------- imprimiendo desde el for---------------------------");

            for (int i=0; i < 3; i++)
            {
                transporte[i].arrancarMotor();
                transporte[i].conducir();
                Console.WriteLine("---------------------------------");
            }

        }
    }

}
