using DCA.practica1.Modelos.Enumerados;
using DCA.practica1.Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCA.practica1.Modelos
{
    public class Portatiles : Producto
    {
        public Single Precio { get; set; }
        public Single Pulgadas { get; set; }
        public String Nombre { get; set; }
        public Marca Marca { get; set; }
        public Procesador Procesador { get; set; }

        public Portatiles(Single precio, Single pulgadas, String nombre, Marca marca, Procesador procesador)
        {
            Precio = precio;
            Pulgadas = pulgadas;
            Nombre = nombre;
            Marca = marca;
            Procesador = procesador;
        }
        public override string ToString()
        {
            return Marca + " - " + Nombre;
        }
    }
}
