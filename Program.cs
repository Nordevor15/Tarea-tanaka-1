using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            bool i = true;
            while (i)
            {
                Console.WriteLine("circulo, rectangulo o triangulo: ");
                n = Console.ReadLine();
                switch (n)
                {
                    case "rectangulo":
                        Console.WriteLine("prueba")
                        break;

                    case "circulo":
                        Console.WriteLine("prueba")
                        break;

                    case "´triangulo":
                        Console.WriteLine("prueba")
                        break;
                    default:
                        Console.WriteLine("No se encontro la figura");
                        break;
                }
                Console.WriteLine("Poner si para seguir, en caso contrario poner lo que desee ");
                string op = Console.ReadLine();
                if (op != "si")
                {
                    i = false;
                }
            }
        }
    }
}
