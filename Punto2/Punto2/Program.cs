using System;

namespace Punto2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de números que desea evaluar: ");
            int cantidadNumeros = int.Parse(Console.ReadLine());

            int[] numeros = new int[cantidadNumeros];
            int suma = 0;
            int mayor = 0;
            int menor = int.MaxValue;
            int cantidadPrimos = 0;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write("Ingrese el número {0}: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];

                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

                if (esPrimo(numeros[i]))
                {
                    cantidadPrimos++;
                }
            }

            double promedio = (double)suma / cantidadNumeros;

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("El mayor número es: {0}", mayor);
            Console.WriteLine("El menor número es: {0}", menor);
            Console.WriteLine("La cantidad de números primos es: {0}", cantidadPrimos);

            Console.ReadLine();
        }

        static bool esPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
