using System;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int ladcuad, ladrect1, ladrect2, basetri, alttri, area, radio, option;
            do
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Calculadora de areas");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Digite 0 para salir");
                Console.WriteLine("Digite 1 para volver al menu");
                Console.WriteLine("Digite 2 para evaluar cubo");
                Console.WriteLine("Digite 3 para evaluar rectangulo");
                Console.WriteLine("Digite 4 para evaluar triangulo");
                Console.WriteLine("Digite 5 para evaluar circulo");
                Console.WriteLine("----------------------------------");
                
                option=Convert.ToInt32(Console.ReadLine());


                switch (option)
                {

                    case 0:break;

                    case 2:

                        Console.WriteLine("Digite el lado del cubo:");
                        ladcuad=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("el area del cubo es :"+(ladcuad*ladcuad)); 
                        Console.WriteLine("seleccione una nueva opcion"); 
                        option=Convert.ToInt32(Console.ReadLine());
                        break;


                    case 3:

                        Console.WriteLine("Digite el lado 1 del rectangulo:");
                        ladrect1=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el lado 2 del rectangulo:");
                        ladrect2=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("el area del cubo es :"+(ladrect1*ladrect2)); break;

                    case 4:

                        Console.WriteLine("Digite la base del triangulo:");
                        basetri=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite la altura del triangulo:");
                        alttri=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("el area del cubo es :"+((basetri*alttri)/2)); break;

                    case 5:

                        Console.WriteLine("Digite el radio de la circunferencia:");
                        radio=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("el area del circulo es :"+(Math.Pow(radio, 2)*(System.Math.PI))); break;


                }

            } while (option==1);
            
        }    
    }   
}
