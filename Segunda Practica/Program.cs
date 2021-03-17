using System;

namespace POO_parctica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto C = new Contacto();

            Console.WriteLine("---Ingrese el nombre del contacto---");

            C.setNombre(Console.ReadLine());
            Console.WriteLine("---Ingrese el apellido del contacto---");

            C.setApellido(Console.ReadLine());

            Console.WriteLine("---Ingrese la direccion del contacto---");

            C.setDireccion(Console.ReadLine());

            Console.WriteLine("---Saludo---");
            C.Saludar();

            Console.ReadKey();

        }
    }
}
