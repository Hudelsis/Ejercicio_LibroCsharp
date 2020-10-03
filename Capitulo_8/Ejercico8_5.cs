using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   namespace Ejercicio_LibroCsharp.Capitulo_8
{
    public class Ejercicio8_5
    {
        public static void Ejercicio()
        {
              string Cadena1 ="juan";
              string Cadena2="ana";
              string Ordenado;


            string cadena = Cadena1 + Cadena2; 
            string ordenado = new String(cadena.OrderBy(z => z).ToArray());
            Ordenado = Convert.ToString(ordenado);
        }
             
    }
}