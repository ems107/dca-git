using DCA.practica1.Modelos.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCA.practica1.Modelos
{
    class Videojuegos
    {
        public Single Precio { get; set; }
        public Single Pulgadas { get; set; }
        public String Nombre { get; set; }
        public Marca Marca { get; set; }
        public Boolean EsConsola { get; set; }

        public Videojuegos(Single precio, Single pulgadas, String nombre, Marca marca, Boolean esConsola)
        {
            Precio = precio;
            Pulgadas = pulgadas;
            Nombre = nombre;
            Marca = marca;
            EsConsola = esConsola;
        }
    }
}
