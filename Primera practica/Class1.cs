using System;
using System.Collections.Generic;
using System.Text;

namespace POO_primera_practica
{
    class Persona
    {
        String Nombre = "Jose", Apellido = "Campusano"; 
        int edad=20;
        long Cedula = 402-3378055-6;

        public void Responsabilidad()
        {
            Console.WriteLine("---Hola---");

            Console.Write(" Mi nombre es: " + Nombre+
                "\n Mi apellido es: " + Apellido +
                "\n Mi edad es: " + edad+
                "\n Mi cedula es: " + Cedula);
        }

    }
    class Profesor : Persona
    {
        int sueldo = 20000;
        public void Sueldo()
        {
            Console.WriteLine("Mi sueldo es: " + sueldo);
        }
    }
   
}
