using System;


namespace Punto2
{
    public class Punto2
    {
        static void Main(string[] args)
        {

            int i = 1, j = 1;
            double n, num, mayor, menor, numPrimos, promedio = 0, contador = 0;

            Console.WriteLine("Ingrese la cantidad de números");
            n = Convert.ToDouble(Console.ReadLine());

            while (i <= n)
            {
                Console.WriteLine($"Digite un número para sacar promedio: {i}");
                num = Convert.ToDouble(Console.ReadLine());

                promedio = promedio + num;
                i++;
            }

            Console.WriteLine($"El promedio de {n} es: {promedio / n}");
            while (n > 0)
            {
                Console.WriteLine($"Digite un número para verificar si es primo: {j}");
                num = Convert.ToDouble(Console.ReadLine());
                num = num + 1;
                j = 1;
                contador = 0;
                while (j <= num)
                {
                    if (num % j == 0)
                    {
                        contador++;
                    }
                    j = j + 1;
                }
                if (contador == 2)
                {
                    Console.WriteLine($"El número {num} es primo");
                    n = n - 1;
                }
            }
        }
    }
}