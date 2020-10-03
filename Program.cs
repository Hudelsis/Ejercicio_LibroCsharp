using System;
using Ejercicio_LibroCsharp.Capitulo_4;
using Ejercicio_LibroCsharp.Capitulo_5;
using Ejercicio_LibroCsharp.Capitulo_6;
using Ejercicio_LibroCsharp.Capitulo_7;
using Ejercicio_LibroCsharp.Capitulo_8;
using Ejercicio_LibroCsharp.Capitulo_9;

namespace Ejercicios_LibroCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            Ejercicio4_5 ejercicio4_5 = new Ejercicio4_5();
            Ejercicio5_4 ejercicio5_4 = new Ejercicio5_4();
            Ejercicio5_5 ejercicio5_5 = new Ejercicio5_5();
            Ejercicio6_1 ejercicio6_1 = new Ejercicio6_1();
            Ejercicio7_1 ejercicio7_1 = new Ejercicio7_1();
            Ejercicio7_2 ejercicio7_2= new Ejercicio7_2();
            Ejercicio7_5 ejercicio7_5 = new Ejercicio7_5();
            Ejercicio8_5 ejercicio8_5 = new Ejercicio8_5();
            Ejercicio8_3 ejercicio8_3 = new Ejercicio8_3();
            Ejercicio9_1_3_4 ejercicio9_1_3_4 = new Ejercicio9_1_3_4();

            while(menu != 14)
            {
            Console.WriteLine("1-Ejercicio 4.1");
            Console.WriteLine("2-Ejercicio 4.2");
            Console.WriteLine("3-Ejercicio 4.5");
            Console.WriteLine("4-Ejercicio 5.4");
            Console.WriteLine("5-Ejercicio 5.5");
            Console.WriteLine("6-Ejercicio 6.1");
            Console.WriteLine("7-Ejercicio 6.2.3");
            Console.WriteLine("9-Ejercicio 7.1");
            Console.WriteLine("10-Ejercicio 7.2");
            Console.WriteLine("11-Ejercicio 7.5");
            Console.WriteLine("12-Ejercicio 8.3");
            Console.WriteLine("13-Ejercicio 8.5");
            Console.WriteLine("14-Ejercicio 9.1.3.4");
            Console.WriteLine("15-Salir");
            Console.WriteLine("Elija una opción: ");
            
            menu = Convert.ToInt32(Console.ReadLine());

                switch(menu)
                {
                case 1:
                    Ejercicio4_1.Ejercicio();
                    break;
                case 2:
                    Ejercicio4_2.Ejercicio();
                    break;
                case 3:
                    ejercicio4_5.Ejercicio();
                    break;
                case 4:
                    ejercicio5_4.Ejercicio();
                    break;
                case 5:
                    ejercicio5_5.Inicializar();
                    break;
                case 6: 
                    ejercicio6_1.promedios();
                    break;

                case 7:
                     Ejercicio6_2_3.Ejercicio();
                     break;  
                case 8:
                    Ejercicio7_1.Ejercicio();
                    break;  
                case 9:
                     Ejercicio7_2.Ejercicio();
                      break;

                case 10:
                       Ejercicio7_5.Ejercicio();
                       break;
                case 11:
                       Ejercicio8_5.Ejercicio();
                       break;
                 case 12:
                       Ejercicio8_3.Ejercicio();
                       break;
                case 13:
                      // Ejercicio9_1_3_4.Ejercicio();
                       break;
                case 14:
                      break;
                default:
                    Console.WriteLine("Opción no existe");
                    break;
                }
            }
            
        }
    }
}