using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aplicación para Calcular área de un cuadrado, rectángulo, triángulo, círculo");
            Console.WriteLine("Porfavor seleccion una opción");

            Console.WriteLine("1. Calcular cuadradao");
            Console.WriteLine("2. Calcular rectangulo");
            Console.WriteLine("3. Calcular triangulo");
            Console.WriteLine("4. Calcular círculo");

            int response = Convert.ToInt32(Console.ReadLine());
            bool switch1 = true;

            while (switch1)
            {

                if (response == 1 | response == 2 | response == 3 | response == 4)
                {
                    switch1 = false;
                }
                else
                {
                    Console.WriteLine("ingrese una opción valida");
                    response = Convert.ToInt32(Console.ReadLine());
                }



            }
        }
    }
}

