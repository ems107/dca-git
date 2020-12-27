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
    public partial class VentanaInicioSesion : Form
    {
        public static VentanaInicioSesion Instancia;

        public VentanaInicioSesion()
        {
            Instancia = this;
            InitializeComponent();
        }

        private void botonInicioSesion_Click(object sender, EventArgs e)
        {
            Usuario intentoInicioSesion = new Usuario(entradaUsuario.Text, entradaContraseña.Text);
            if (FakeDataBase.Usuarios.Contains(intentoInicioSesion))
            {
                VentanaTienda ventana = new VentanaTienda();
                ventana.Show();
                this.Hide();
            }
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            VentanaRegistrar ventana = new VentanaRegistrar();
            ventana.Show();
        }
    }
}
