using System;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo para calcular el promedio de N numeros");

            int n;
            bool switch1 = true;

            while (switch1)
            {
                Console.WriteLine("cuantos numeros desea ingresar?: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    switch1 = false;
                }
                else
                {
                    Console.WriteLine("Ingrese una opción válida.");
                }


                double suma = 0;
                double mayor1 = 0;
                for (int i = 1; i <= n; i++)
                {
                    mayor1 = 0;
                    Console.WriteLine("Ingrese el número " + i + ":");
                    double numero = Convert.ToDouble(Console.ReadLine());
                    suma += numero;

                    if (numero > mayor1 | i ==1)
                    {
                        mayor1 = numero;

                    }
                    
                }
                double promedio = suma / n;

                double mayor2 = mayor1;
                Console.WriteLine("el numero mayor es: " + mayor1);



                Console.WriteLine("El promedio de los " + n + " números ingresados es: " + promedio);
            }

        }
    }
}

