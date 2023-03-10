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
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Digite 1 para cubo");
            
            Console.WriteLine("Digite 2 para rectangulo");
           
            Console.WriteLine("Digite 3 para triangulo");
            
            Console.WriteLine("Digite 4 para circulo");

            option=Convert.ToInt32(Console.ReadLine());
            
            
                switch(option)
                { 








                   case 1:
                    
                        Console.WriteLine("Digite el lado del cubo:");
                        ladcuad=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("el area del cubo es :"+(ladcuad*ladcuad)); break;

                    case 2:
                    
                        Console.WriteLine("Digite el lado 1 del rectangulo:");
                        ladrect1=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el lado 2 del rectangulo:");
                        ladrect2=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("el area del cubo es :"+(ladrect1*ladrect2)); break;

                case 3:

                    Console.WriteLine("Digite la base del triangulo:");
                    basetri=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite el lado 1 del rectangulo:");
                    alttri=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("el area del cubo es :"+((basetri*alttri)/2)); break;

                case 4:

                    Console.WriteLine("Digite el radio de la circunferencia:");
                    radio=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("el area del circulo es :"+(Math.Pow(radio, 2)*(System.Math.PI))); break;


            }


        }
    }
}
