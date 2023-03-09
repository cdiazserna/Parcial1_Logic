using System;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, shtw = 1;
            double num1, num2, num3, cuadrado, rectangulo, triangulo, circulo;



            


            Console.WriteLine(" ");
            Console.WriteLine("                ********************                   ");
            Console.WriteLine("Punto 1 : Calculadora de Figuras Geometricas");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" elige una de las opciones del menu");
            Console.WriteLine("   1 Para Calcular Area de Cuadrado");
            Console.WriteLine("   2 Para Calcular Area de Un Rectangulo");
            Console.WriteLine("   3 Para Calcular Area de Un Triangulo");
            Console.WriteLine("   4 Para Calcular Area de Un Circulo");
            Console.WriteLine("   0 Para Salir");

     
            opcion =Convert.ToInt32(Console.ReadLine()); 

            switch (opcion)
            {
                case 0:
                    shtw=0;
                
                    break;
                    case 1:
                    Console.WriteLine("Ingresa Por Favor el valor del Lado del Cuadrado");
                    num1= Convert.ToInt32(Console.ReadLine());
                    cuadrado = num1 * num1;

                    Console.WriteLine(" ");
                    Console.WriteLine(cuadrado);
                    break;
                case 2:
                    Console.WriteLine("Ingresa Por Favor el valor de la BASE");
                    num1= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingresa Por Favor el Valor de la ALTURA");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    rectangulo = num1 * num2;
                    break;



            
            
            
            }

            


        }
    }
}
