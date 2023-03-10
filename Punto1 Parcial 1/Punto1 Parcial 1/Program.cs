using System;

namespace Punto1_Parcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aplicación para Calcular área de un cuadrado, rectángulo, triángulo, círculo");
            Console.WriteLine("Porfavor seleccion una opción");


            
                        int response = 0;
                        bool switch1 = true;
                        //Console.Clear();
                        bool switchPrincipal = true;

                        while (switchPrincipal)

                        {
                        //response = Convert.ToInt32(Console.ReadLine());
                            while (switch1)
                            {
                            Console.WriteLine("1. Calcular cuadradao");
                            Console.WriteLine("2. Calcular rectangulo");
                            Console.WriteLine("3. Calcular triangulo");
                            Console.WriteLine("4. Calcular círculo");
                            Console.WriteLine("0. Salir");

                    response = Convert.ToInt32(Console.ReadLine());
                            

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
                                        switchPrincipal= true;
                                        break;

                                        case 2:
                                            Console.WriteLine("Ingrese la longitud del lado del rectángulo:");
                                            double largo = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Ingrese la anchura del rectángulo:");
                                            double ancho = Convert.ToDouble(Console.ReadLine());
                                            area = largo * ancho;
                                            Console.WriteLine("El área del rectángulo es: " + area);

                                            switch1 = true;
                                            switchPrincipal = true;
                                            break;

                                        case 3:

                                        Console.WriteLine("Ingrese la base del triángulo:");
                                        double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Ingrese la altura del triángulo:");
                                        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                                        area = (baseTriangulo * alturaTriangulo) / 2;
                                        Console.WriteLine("El área del triángulo es: " + area);
                                        break;

                                        case 4:
                                        Console.WriteLine("Ingrese el radio del círculo:");
                                        double radio = Convert.ToDouble(Console.ReadLine());
                                        double area = 3.14159 * radio * radio;
                                        Console.WriteLine("El área del círculo es: " + area);

                            Console.WriteLine("Circulo");
                                        break;
                                }

                            }


                        }

                    }
                        
        }
    }

