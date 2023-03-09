using System;

namespace Punto1
{
    public class Punto1
    {
        static void Main(string[] args)
        {
            double lado, b, altura, areaCuad, areaTrian, areaRectan, areaCirc;
            int option;

            Console.WriteLine("******");
            Console.WriteLine("*Menú*");
            Console.WriteLine("******");
            Console.WriteLine("1. Calcular área de un cuadrado ");
            Console.WriteLine("2. Calcular área de un rectángulo");
            Console.WriteLine("3. Calcular área de un triángulo");
            Console.WriteLine("4. Calcular área de un círculo");

            option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el lado");
            lado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el lado");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el lado");
            altura = Convert.ToDouble(Console.ReadLine());



            switch (option)
            {
                case 1:

                    areaCuad = Math.Pow(lado, 2);

            }




        }
    }
}