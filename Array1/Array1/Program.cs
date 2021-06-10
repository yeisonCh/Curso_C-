using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades;
            edades = new int[4];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;
            
            Console.WriteLine(edades[3]);

            int[] edad = { 23, 23, 24, 80 };

            Console.WriteLine(edad[3]);

            // ARRAY IMPLICITO  no se especifica el tipo de dato que almacenamos 

            var datos = new[] { "Andres", "Sandra ", "Joel", "Gabriel" };

            var otroValor = new[] { 15, 22, 43, 56.6, 80, 12.4 }; //todos los datos los oasa a double



            Empleados Ana = new Empleados("Ana",24);

            //array de tipo objetos 

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Andres", 37);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Sandra", 22);

            // Array de clases anonimas

            var personas = new[]
            {

                new {Nombre="Andres", Edad =19},
                new {Nombre= "María", Edad=23},
                new {Nombre= "Diana", Edad= 35}

            };
            Console.WriteLine(personas[1]);
            Console.WriteLine(arrayEmpleados[1]);

            for (int i=0; i <=5; i++)
            {
                Console.WriteLine(otroValor[i]);
            }

            for(int i=0; i<arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }


            foreach(double variable in otroValor)// lo proimero que colocamos es el tipo almacena el arrary si es primitivo o un objeto
            {
                Console.WriteLine(variable);
            }

            foreach(Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getInfo());
            }
            //si es un array anonimo solo utilizamos var y ya 
            foreach(var variable in personas)
            {
                Console.WriteLine(variable);
            }
        }
    }

    class Empleados
    {
        public Empleados (string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getInfo()
        {
            return "El nombre del empleado es: "+ nombre + ", y la edad es: "+ edad;
        }

       private string nombre;
       private int edad;
    }
}
