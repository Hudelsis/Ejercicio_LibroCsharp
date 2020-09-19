
using System;

namespace Ejercicio_LibroCsharp.Capitulo_4
{
    public class Ejercicio4_2
    {
        public static void Ejercicio()
        {
            int number,power;
            Console.WriteLine("Introduzca el numero el cual desea potenciar: ");

            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la potencia: ");

            power = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine($"{number}^{power} = {Math.Pow(number, power)}");
        
        }
    }
}