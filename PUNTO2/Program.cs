﻿using System;

namespace PUNTO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros, NUM,
            double promediototal;
            int nummayor=0, nummenor, numprimos=0, sumanumero;
            int operadorfor;

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("OPERACIONES ENTRE N NÚMEROS NATURALES");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Cúantos números desea ingresar");
            numeros = Convert.ToInt32(Console.ReadLine());

            for (operadorfor=0; operadorfor<numeros; operadorfor++)
            {
                Console.WriteLine("Ingresa los números por favor");
                NUM=Convert.ToInt32(Console.ReadLine()) ;

                if (operadorfor == 0)
                {
                    nummayor = numeros;
                    nummenor = numeros;
                }
                else
                {
                    if (numeros > nummayor)
                    {
                        nummayor = numeros;
                    }
                    if (numeros < nummayor)
                    {
                        nummenor = numeros;
                    }
                }

                if (numprimos(numeros))
                {
                    numprimos++;
                }
            }

        }
    }
}
