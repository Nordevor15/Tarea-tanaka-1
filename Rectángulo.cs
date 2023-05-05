using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base del rectángulo: ");
            double baseRectangulo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del rectángulo: ");
            double alturaRectangulo = double.Parse(Console.ReadLine());
            double areaRectangulo = baseRectangulo * alturaRectangulo;
            double perimetroRectangulo = baseRectangulo + baseRectangulo  + alturaRectangulo + alturaRectangulo;
            Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
            Console.WriteLine("El perímetro del rectángulo es:" + perimetroRectangulo);

            while (true)
            {
                Console.WriteLine("Presione cualquier tecla para salir del programa.");
                Console.ReadKey();
                break;
            }



        }
    }
}
