using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   namespace Ejercicio_LibroCsharp.Capitulo_8
{
    public class Ejercicio8_3
    {
        public static void Ejercicio()
        {
             string Hora;
             string Fecha;

            DateTime Hoy = DateTime.Now;
            Hora= Hoy.ToString("hh:mm:ss tt");
            Fecha = Hoy.ToString("dd/MMMM/yyyy");
        }
              
             
    }
}