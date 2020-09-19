using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   namespace Ejercicio_LibroCsharp.Capitulo_4
{
    public class Ejercicio4_1
    {
        public static void Ejercicio()
        {
           int number = 0;

          Console.WriteLine("Introduzca el numero del cual quiere ver su tabla:");
          number = Convert.ToInt32(Console.ReadLine());
          for(int i = 1; i <= 10; i++)
          Console.WriteLine($"{i} X {number} = {number*i}");        
        }
    }
}