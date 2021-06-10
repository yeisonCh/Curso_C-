using System;

namespace Genericos1
{
    class Program
    {
        static void Main(string[] args)
        {

            AlmaceObjetos archivos = new AlmaceObjetos(4);

            archivos.SetAgregar("Juan");
            archivos.SetAgregar("Elena");
            archivos.SetAgregar("Antonio");
            archivos.SetAgregar("Sandra");

            //creamos una variable de tipo string 
            //debemos hacer un casting 
            String nombrePersona = (string)archivos.GetElemento(3);
            Console.WriteLine(nombrePersona);

            AlmaceObjetos empleado = new AlmaceObjetos(3);

            //en estas lineas instanciamos la clase empleado y despues la colocamos en el Seter 
            Empleado andres = new Empleado(3000);
            Empleado sandra = new Empleado(5000);


            empleado.SetAgregar(new Empleado(2000));//en esta instrucción instanciamos la clase directamente 
            empleado.SetAgregar(sandra);
            empleado.SetAgregar(andres);

            Empleado salarioEmpleado = (Empleado)empleado.GetElemento(0);
            Empleado salarioEmpleado1 = (Empleado)empleado.GetElemento(2);

            Console.WriteLine(salarioEmpleado.GetSalario());
            Console.WriteLine(salarioEmpleado1.GetSalario());
            


        }
    }
    //USO DE LA HERENCIA PARA CREAR CLASES QUE NOS VALGAN PARA TODO
    //creamos la clase almacen de objetos 
    class AlmaceObjetos 
    {
        //creamos un constructor 
        public AlmaceObjetos(int z) 
        {
            datosElemento = new Object[z]; //creamos un objeto que hereda de la super clase object para guardar un elemento de cualquier tipo

        }

        public void SetAgregar(object obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public Object GetElemento(int i)
        {
            return datosElemento[i];
        }

        private Object[] datosElemento;

        private int i = 0;
    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }

        private double salario;
    }
}
