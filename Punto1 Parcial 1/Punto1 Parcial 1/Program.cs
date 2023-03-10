using System;

namespace Punto1_Parcial_1
{
    internal class Program
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

                        //while (switchPrincipal)

                        //{
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
                                        
                                        Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
                                        double lado = Convert.ToDouble(Console.ReadLine());
                                        double area = lado * lado;
                                        Console.WriteLine("El área del cuadrado es: " + area);
                                        switch1 = true;
                                        break;

                                        case 2:
                                        Console.WriteLine("Rectangulo");
                                        break;

                                        case 3:

                                        Console.WriteLine("Triangulo");
                                        break;

                                        case 4:

                                        Console.WriteLine("Circulo");
                                        break;
                                }

                            //}


                        }

                    }
                        
        }
    }

