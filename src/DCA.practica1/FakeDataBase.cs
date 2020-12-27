using DCA.practica1.Modelos;
using DCA.practica1.Modelos.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCA.practica1
{
    public static class FakeDataBase
    {
        public static List<DispositivoMovil> DispositivosMoviles { get; set; } = new List<DispositivoMovil>
        {
            new DispositivoMovil(250, 6, "Mi 9T", Marca.Xiaomi),
            new DispositivoMovil(350, 6, "Mi 10", Marca.Xiaomi),
            new DispositivoMovil(150, 6, "Mi 9T", Marca.Xiaomi),
            new DispositivoMovil(1250, 6, "Note 11", Marca.Samsung),
            new DispositivoMovil(250.99f, 6, "A8", Marca.Samsung),
            new DispositivoMovil(300, 6, "Pixel 2", Marca.Google),
            new DispositivoMovil(830, 6, "Pixel 3", Marca.Google),
            new DispositivoMovil(1500, 6, "Iphone 12", Marca.Apple),
            new DispositivoMovil(400, 6, "X1", Marca.Sony)
        };

        public static List<Portatiles> Portatiles { get; set; } = new List<Portatiles>
        {
            new Portatiles(1350, 6, "Surface Book 2", Marca.Microsoft, Procesador.Intel_i7),
            new Portatiles(150, 6, "Chromebook", Marca.Google, Procesador.Desconocido),
            new Portatiles(150, 6, "Mac Pro", Marca.Apple, Procesador.Desconocido)
        };

        public static List<Videojuegos> Videojuegos { get; set; } = new List<Videojuegos>
        {
            new Videojuegos(399, 6, "PS5 Digital", Marca.Sony, true),
            new Videojuegos(350, 6, "Xbox Series S", Marca.Ninendo, true),
            new Videojuegos(330, 6, "Switch", Marca.Microsoft, true),
            new Videojuegos(499, 6, "PS5 Estandar", Marca.Sony, true),
            new Videojuegos(70, 6, "The Last Of Us 2", Marca.Sony, false),
            new Videojuegos(60, 6, "Mario Odissey", Marca.Ninendo, false)
        };

        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>
        {
            new Usuario("usuario", "1234")
        };
    }
}
