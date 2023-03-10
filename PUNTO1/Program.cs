using System;

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
            int opcionmenu;

            while (menu == 1)
            {
                Console.WriteLine("Qué operación desea hacer?");

                Console.WriteLine("---------------------------");

                Console.WriteLine("Calcular el área de un cuadrado (PRESIONE 1) ");
                Console.WriteLine("Calcular el área de un rectangulo (PRESIONE 2)");
                Console.WriteLine("Calcular el área de un triángulo (PRESIONE 3)");
                Console.WriteLine("Calcular el área de un círculo (PRESIONE 4)");

                opcionmenu = Convert.ToInt32(Console.ReadLine());

                switch (opcionmenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("CALCULAR ÁREA DE UN CUADRADO");
                        Console.WriteLine("Ingrese el valor del lado de su cuadrado");

                        primernum = Convert.ToInt32(Console.ReadLine());

                        cuad = primernum * primernum;
                        Console.WriteLine("El área de su cuadrado es:" + cuad);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("CALCULAR ÁREA DE UN RECTANGULO");
                        Console.WriteLine("Ingrese el valor de la base");
                        primernum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la altura");
                        segundonum = Convert.ToInt32(Console.ReadLine());

                        rect = primernum * segundonum;
                        Console.WriteLine("El área de su rectangulo es:" + rect);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("CALCULAR ÁREA DE UN TRIÁNGULO");
                        Console.WriteLine("Ingrese el valor de la base");
                        primernum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de la altura");
                        segundonum = Convert.ToInt32(Console.ReadLine());

                        tria = (primernum + segundonum) / 2;
                        Console.WriteLine("El área de su triángulo es:" + tria);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("CALCULAR ÁREA DE UN CÍRCULO");
                        Console.WriteLine("Ingrese el valor del Radio de su círculo");

                        primernum = Convert.ToInt32(Console.ReadLine());

                        circ = Math.PI * Math.Pow(primernum, 2);
                        Console.WriteLine("El área de su círculo es:" + circ);

                        break;

                    default:
                        Console.WriteLine("Presione una opción válida");
                        break;
                }

            }



        }
    }
}
