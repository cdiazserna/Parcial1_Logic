﻿using System;

namespace Punto1
{
    public class Punto1
    {
        static void Main(string[] args)
        {
            double lado, b, altura,radio, areaCuad, areaTrian, areaRectan, areaCircu;
            int option, sw=1;


                    Console.WriteLine("******");
                    Console.WriteLine("*Menú*");
                    Console.WriteLine("******");
                    Console.WriteLine("1. Calcular área de un cuadrado ");
                    Console.WriteLine("2. Calcular área de un rectángulo");
                    Console.WriteLine("3. Calcular área de un triángulo");
                    Console.WriteLine("4. Calcular área de un círculo");
                    Console.WriteLine("Digite 0 para salir");

                    Console.WriteLine("Selecciona una de las opciones del menú");
                    option = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Por favor ingrese el lado");
                    lado = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Por favor ingrese el lado");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Por favor ingrese el lado");
                    altura = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Por favor ingrese el lado");
                    radio = Convert.ToDouble(Console.ReadLine());

            while (sw == 1)
            {
                   
                        switch (option)
                        {
                            case 1:

                                areaCuad = Math.Pow(lado, 2);
                                Console.WriteLine($"El área del cuadrado es: {areaCuad}");
                                break;

                            case 2:

                                areaRectan = b * altura;
                                Console.WriteLine($"El área del rectángulo es: {areaRectan}");
                                break;

                            case 3:

                                areaTrian = (b * altura) / 2;
                                Console.WriteLine($"Elk área del triángulo es: {areaTrian}");
                                break;

                            case 4:

                                areaCircu = Math.PI * Math.Pow(radio, 2);
                                Console.WriteLine($"Elk área del círculo es: {areaCircu}");
                                break;

                        }


            }






        }
    }
}