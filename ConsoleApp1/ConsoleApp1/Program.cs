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
            Console.Clear();
            bool switchPrincipal = true;

            while (switchPrincipal)

            {
                while (switch1)
                {

                    if (response == 1 | response == 2 | response == 3 | response == 4 | response == 0 )
                    {
                        switch1 = false;
                    }
                    else
                    {
                        Console.WriteLine("ingrese una opción valida");
                        response = Convert.ToInt32(Console.ReadLine());
                    }

                }

                if (response == 0)
                {
                    Console.WriteLine("ha salido correctamente.la ejecución ha finalizado");
                    switchPrincipal= false;
                }
                else
                {
                    switch (response)
                    {
                        case 1:
                            double radio, area;
                            Console.WriteLine("Calculadora de área de un círculo\n");
                            Console.Write("Ingresa el radio del círculo: ");
                            radio = double.Parse(Console.ReadLine());

                            area = Math.PI * Math.Pow(radio, 2);

                            Console.WriteLine("El área del círculo es: " + area);

                            break;

                            case 2:

                            double baseRectangulo, alturaRectangulo, areaRectangulo;

                            Console.WriteLine("Calculadora de área de un rectángulo\n");
                            Console.Write("Ingresa la base del rectángulo: ");
                            baseRectangulo = double.Parse(Console.ReadLine());
                            Console.Write("Ingresa la altura del rectángulo: ");
                            alturaRectangulo = double.Parse(Console.ReadLine());

                            areaRectangulo = baseRectangulo * alturaRectangulo;

                            Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
                            break;

                            case 3:
                    }

                }


            }
        }
    }
}

