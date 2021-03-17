using System;
using System.Collections.Generic;
using System.Text;

namespace POO_primera_practica
{
    class A
    {
        public void Hola()
        {
            Console.WriteLine("Hola caballero");
        }
    }
    class B : A
    {
        public void respuesta()
        {
            Console.WriteLine("Hola señorita");
        }
    }
    class C : B 
    {
        
    }
}
