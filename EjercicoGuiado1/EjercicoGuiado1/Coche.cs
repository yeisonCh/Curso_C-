using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicoGuiado1
{
    class Coche:Transporte
    {
        public override void conducir()
        {
            Console.WriteLine("Los coches necesitan un conductor para conducir por la carretera");
            //base.conducir();
        }
    }
}
