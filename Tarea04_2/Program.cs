using System;

namespace Tarea04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Introduce ciudad:");
            String ciudad = Console.ReadLine();

            Console.WriteLine("Hola  {0}, bienvenido/a a {1}.",nombre,ciudad);

            Console.ReadKey();
        }
    }
}
