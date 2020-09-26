using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Ejercicio_LibroCsharp.Capitulo_7
{
    class Ejercicio7_1
    {
        public static void Ejercicio()
        {
                int[] nota = new int[15];
                int N, max = nota[0], min = nota[0];
                for(int i = 0; i < 15; i++)
                {
                       Console.Write("Introduzca de la nota: ");
                       N = int.Parse(Console.ReadLine());
                       nota[i] = N;
                }
                Console.Write("La nota maxima es: " + nota.Max());
                Console.Write("La nota minima es: " + nota.Min());
                Console.ReadKey();
                         
     
     

        
        }    
    }                  

}
    
