using System;

namespace GenericosClases
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmaceObjetos<String> archivos = new AlmaceObjetos<String>(4);
            // dentro de < > especificamos de clase sera nuestro objeto en este caso es de tipo string

            archivos.SetAgregar("Juan");
            archivos.SetAgregar("Elena");
            archivos.SetAgregar("Antonio");
            archivos.SetAgregar("Sandra");

            //creamos una variable de tipo string 
            // podemos presindir del casting 
            String nombrePersona = archivos.GetElemento(3);
            Console.WriteLine(nombrePersona);

            // dentro de < > especificamos de clase sera nuestro objeto en este caso es de tipo Empleado o de Objeto de tipo emplead
            AlmaceObjetos<Empleado> empleado = new AlmaceObjetos<Empleado>(3);

            //en estas lineas instanciamos la clase empleado y despues la colocamos en el Seter 
            Empleado andres = new Empleado(3000);
            Empleado sandra = new Empleado(5000);


            empleado.SetAgregar(new Empleado(2000));//en esta instrucción instanciamos la clase directamente 
            empleado.SetAgregar(sandra);
            empleado.SetAgregar(andres);

            Empleado salarioEmpleado = empleado.GetElemento(0);
            Empleado salarioEmpleado1 =empleado.GetElemento(2);

            Console.WriteLine(salarioEmpleado.GetSalario());
            Console.WriteLine(salarioEmpleado1.GetSalario());
        }
    }
    //esta clase nos va a menjar cualquier tipo de objeto
    class AlmaceObjetos<T> //para crear un clase generica se realiza usando <> y dentro un letra que por convencion es una T
    {
        //creamos un constructor 
        public AlmaceObjetos(int z)
        {
            datosElemento = new T [z]; //creamos un objeto que hereda de la super clase object para guardar un elemento de cualquier tip

        }

        public void SetAgregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public  T GetElemento(int i)
        {
            return datosElemento[i];
        }

        private T [] datosElemento;

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
