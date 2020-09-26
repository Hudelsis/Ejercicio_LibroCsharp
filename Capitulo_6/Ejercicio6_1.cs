using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_LibroCsharp.Capitulo_6
{
     public class Ejercicio6_1
    {
        private double[] notas = new double[5];
        private int n = 0;

        public void insertar(double nota)
        {
            if (n == 5) { }
            else
            {
                notas[n] = nota;

            }

        }
        public double promedios()
        {

             Console.WriteLine("Introduzca la nota: ");
            n = Convert.ToInt32(Console.ReadLine());
            double prom = 0;
            double suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma = suma + notas[i];
            }
            prom = suma / n;
            return prom;

        }
    }
}