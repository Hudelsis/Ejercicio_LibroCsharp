using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_LibroCsharp.Capitulo_10
{
    class Ejercicio10_1
    {
        
        public class Inventario
        {
            private int ID { get; set; }
            private string nombre { get; set; }
            private double precio { get; set; }
            private double costo { get; set; }
            private double cantidad { get; set; }


            public Inventario()
            {
                ID = 0;
                precio = 0;
                costo = 0;
                cantidad = 0;
            }


            public Inventario(int id, string nombre, double costo, double precio, double cantidad)
            {
                this.ID = id;
                this.nombre = nombre;
                this.costo = costo;
                this.precio = precio;
                this.cantidad = cantidad;
            }
        }
    }
}