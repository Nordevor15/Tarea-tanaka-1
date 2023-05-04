using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";

            while (opcion != "salir")
            {
                Console.WriteLine("¿Qué desea calcular? (Escriba 'area' o 'perimetro', o escriba 'salir' para terminar)");
                opcion = Console.ReadLine().ToLower();

                if (opcion == "area")
                {
                    // Pedir al usuario que ingrese la base y la altura del triángulo
                    Console.WriteLine("Coloque la base:");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Coloque la altura:");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                    // Calcular el área del triángulo
                    double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

                    // Mostrar el resultado
                    Console.WriteLine("El área del triángulo es: " + areaTriangulo);
                }
                else if (opcion == "perimetro")
                {
                    // Pedir al usuario que ingrese los lados del triángulo
                    Console.WriteLine("Ingrese el primer lado del triángulo:");
                    double lado1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo lado del triángulo:");
                    double lado2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el tercer lado del triángulo:");
                    double lado3 = Convert.ToDouble(Console.ReadLine());

                    // Calcular el perímetro del triángulo
                    double perimetroTriangulo = lado1 + lado2 + lado3;

                    // Mostrar el resultado
                    Console.WriteLine("El perímetro del triángulo es: " + perimetroTriangulo);
                }
                else if (opcion != "salir")
                {
                    // Mostrar un mensaje de error si la opción ingresada es incorrecta
                    Console.WriteLine("La opción ingresada es incorrecta.");
                }

                Console.WriteLine(); // Agregar una línea en blanco para separar las respuestas del usuario
            }

            Console.WriteLine("Gracias por utilizar mi programa. Presione Enter para salir.");
            Console.ReadLine(); // Esperar a que el usuario presione Enter para cerrar la ventana
        }
    }
}


