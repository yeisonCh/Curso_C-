using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicoGuiado1
{
    class Transporte
    {
        public void arrancarMotor()
        {
            Console.WriteLine("El MOTOR esta arrancando");
        }

        public void pararMotor()
        {
            Console.WriteLine("El MOTOR se ha detenido");
        }

        public virtual void conducir()
        {
            Console.WriteLine("los medios de transporte necesitan un conductor");
        }

    }

    
}
