using System;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladcuad, ladrect1, ladrect2, basetri, alttri, area, radio,option;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Calculadora de areas");
           
            Console.WriteLine("Digite 1 para cubo");
            
            Console.WriteLine("Digite 2 para rectangulo");
           
            Console.WriteLine("Digite 3 para triangulo");
            
            Console.WriteLine("Digite 4 para circulo");

            option=Convert.ToInt32(Console.ReadLine());
            
            
                switch(option)
                { 
                   case 1:
                    
                        Console.WriteLine("Digite el lado del cubo:");
                        Console.WriteLine("el area del cubo es :"+ladcuad*ladcuad); break;

                    
            }


        }
    }
}
