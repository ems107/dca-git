using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCA.practica1.Modelos
{
    public class Usuario
    {
        public String Nombre { get; set; }
        public String Contraseña { get; set; }
        public Usuario(String nombre, String contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }
        public override bool Equals(object obj)
        {
            return obj is Usuario && (obj as Usuario).Nombre == Nombre && (obj as Usuario).Contraseña == Contraseña;
        }
    }
}
