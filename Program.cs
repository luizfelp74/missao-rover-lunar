using System;

namespace RoverLunar
{
    internal class Program
    {
        static void InicializarRover()
        {
            Console.WriteLine("Sistemas do Rover iniciados!");
            Console.WriteLine("Painéis solares: OK");
            Console.WriteLine("Nível de bateria: 100%");
        }

        static void Main(string[] args)
        {
            InicializarRover();
        }
    }
}