using DCA.practica1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCA.practica1
{
    public partial class VentanaRegistrar : Form
    {
        public VentanaRegistrar()
        {
            InitializeComponent();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            FakeDataBase.Usuarios.Add(new Usuario(entradaNombreUsuario.Text, entradaContraseña.Text));
            Close();
        }
    }
}
