using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicoGuiado1
{
    class Vehiculo : Transporte
    {
      
            public override void conducir()
            {
                Console.WriteLine("Es un medio de transporte que puede ser un bote o un barco, neceita un capitan para navegar");
                //base.conducir();
            }
        
    }
}
