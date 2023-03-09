using System;

namespace Punto1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double valor1, valor2, area;


            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular área de un cuadrado");
            Console.WriteLine("2. Calcular área de un rectángulo");
            Console.WriteLine("3. Calcular área de un triángulo");
            Console.WriteLine("4. Calcular área de un círculo");
            Console.WriteLine("0. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el valor del lado del cuadrado:");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    area = valor1 * valor1;
                    Console.WriteLine("El área del cuadrado es: " +area);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el valor de la base del rectángulo:");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la altura del rectángulo:");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                    area = valor1 * valor2;
                    Console.WriteLine("El área del rectángulo es: " +area);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el valor de la base del triángulo:");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la altura del triángulo:");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                    area = valor1 * valor2 / 2;
                    Console.WriteLine("El área del triángulo es: " +area);
                    break;
                case 4:
                    Console.WriteLine("Ingrese el valor del radio del círculo:");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    area = Math.PI * valor1 * valor1;
                    Console.WriteLine("El área del círculo es: " +area);
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }

        }
        }
    }
}
