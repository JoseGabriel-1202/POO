using System;
using System.Collections.Generic;
using System.Text;

namespace POO_practica_3
{
    class A
    {
        public void Saludo()
        {
            Console.WriteLine("Hola, como esta?");
        }
    }
    class B : A
    {
        public void Respuesta()
        {
            Console.WriteLine("yo estoy bien y usted?");
        }
    }
    class C : B
    {
      
    }
}
