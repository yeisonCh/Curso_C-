using System;

namespace StructsYEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 260);

            empleado1.CambiaSalario(empleado1, 100);
            Console.WriteLine(empleado1);
        }
    }
    public struct Empleado //las estructuras se almacenan en la memoria STACK 

       //LAS CLASES se almacenan en la memoria HEAP
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;

        }

        public override string ToString()
        {
            return string.Format("Salario y comisión del empleado ({0},{1})", this.salarioBase, this.comision);
        }

        public void CambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;

            emp.comision += incremento;
        }
    }
}

