using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_LibroCsharp.Capitulo_7
{
    class Ejercicio7_2
    {
        public static void Ejercicio()
        {

            
           
            Hashtable miDiccio = new Hashtable();

            miDiccio.Clear();
            
            miDiccio.Add("byte", "8 bits");
            miDiccio.Add("pc", "personal computer");
            miDiccio.Add("PC", "ordenador personal");
            miDiccio.Add("kilobyte", "1024 bytes");
            miDiccio.Add("bit", "");

            miDiccio.Remove("PC");

           
            Console.WriteLine("Cantidad de palabras en el diccionario: {0}",
            miDiccio.Count);
            if (miDiccio.ContainsKey("bit")) {
           
                Console.WriteLine("El significado de bit es: {0}",
                miDiccio["bit"]);
            }
            else
            {
                Console.WriteLine("No existe esa palabra!");
            }

            Console.ReadKey();
        }
    }
}