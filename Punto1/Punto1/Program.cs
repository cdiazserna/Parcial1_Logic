using System;

namespace Punto1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double val1, val2, area;

            do
            {
                Console.WriteLine("Seleccione una opción, para calcular el área de la figuras mencionadas:");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Calcular área de un cuadrado");
                Console.WriteLine("2. Calcular área de un rectángulo");
                Console.WriteLine("3. Calcular área de un triángulo");
                Console.WriteLine("4. Calcular área de un círculo");

                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    case 1:
                        Console.WriteLine("Ingrese el valor del lado del cuadrado:");
                        val1 = Convert.ToDouble(Console.ReadLine());
                        area = val1 * val1;
                        Console.WriteLine("El área del cuadrado es: " + area);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el valor de la base del rectángulo:");
                        val1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la altura del rectángulo:");
                        val2 = Convert.ToDouble(Console.ReadLine());
                        area = val1 * val2;
                        Console.WriteLine("El área del rectángulo es: " + area);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el valor de la base del triángulo:");
                        val1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la altura del triángulo:");
                        val2 = Convert.ToDouble(Console.ReadLine());
                        area = val1 * val2 / 2;
                        Console.WriteLine("El área del triángulo es: " + area);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el valor del radio del círculo:");
                        val1 = Convert.ToDouble(Console.ReadLine());
                        area = Math.PI * val1 * val1;
                        Console.WriteLine("El área del círculo es: " + area);
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 0);

        }
    }
    
}


