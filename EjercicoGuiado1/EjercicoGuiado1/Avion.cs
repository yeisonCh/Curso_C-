using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicoGuiado1
{
    class Avion:Transporte
    {
        public override void conducir()
        {
            Console.WriteLine("Los aviones necesitan un piloto para volar");
            //base.conducir();
        }
    }
}
