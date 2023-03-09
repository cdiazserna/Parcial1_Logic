using System;
using System.Security.Cryptography;

namespace PUNTO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("PROGRAMA PARA CALCULAR ÁREAS");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            double primernum, segundonum;
            double cuad, tria, rect, circ;
            int menu = 1;
            int resultado;

            while (menu == 1)
            {
                Console.WriteLine("Qué operación desea hacer?");

                Console.WriteLine("---------------------------");

                Console.WriteLine("Calcular el área de un cuadrado (PRESIONE 1) ");
                Console.WriteLine("Calcular el área de un rectangulo (PRESIONE 2)");
                Console.WriteLine("Calcular el área de un triángulo (PRESIONE 3)");
                Console.WriteLine("Calcular el área de un círculo (PRESIONE 4)");

                resultado = Convert.ToInt32(Console.ReadLine());

                switch (resultado)
                {
                    case 1:
                        suma = primernumero + segundonumero;
                        Console.WriteLine("El resultado de la suma es:" + suma);
                        break;

                    case 2:
                        resta = primernumero - segundonumero;
                        Console.WriteLine("El resultado de la resta es:" + resta);
                        break;

                    case 3:
                        mult = primernumero * segundonumero;
                        Console.WriteLine("El resultado de la multiplicación es:" + mult);
                        break;

                    case 4:
                        if (segundonumero == 0)
                        {
                            Console.WriteLine("La división es indeterminada");

                        }
                        else
                        {
                            division = primernumero / segundonumero;
                            Console.WriteLine("El resultado de la división es:" + division);
                        }

                        break;

                    default:
                        Console.WriteLine("Presione una opción válida");
                        break;
                }

        }
    }
}
