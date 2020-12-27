using DCA.practica1.Modelos;
using DCA.practica1.Modelos.Interfaces;
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
    public partial class VentanaTienda : Form
    {
        public static VentanaTienda Instancia;

        public VentanaTienda()
        {
            Instancia = this;
            InitializeComponent();
        }

        private void botonVideojuegos_Click(object sender, EventArgs e)
        {
            VentanaListadoProductos ventana = new VentanaListadoProductos(FakeDataBase.Videojuegos.ToArray());
            ventana.Show();
            this.Hide();
        }

        private void botonPortatiles_Click(object sender, EventArgs e)
        {
            VentanaListadoProductos ventana = new VentanaListadoProductos(FakeDataBase.Portatiles.ToArray());
            ventana.Show();
            this.Hide();
        }

        private void botonDispositivosMoviles_Click(object sender, EventArgs e)
        {
            VentanaListadoProductos ventana = new VentanaListadoProductos(FakeDataBase.DispositivosMoviles.ToArray());
            ventana.Show();
            this.Hide();
        }

        private void VentanaTienda_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instancia = null;
            VentanaInicioSesion.Instancia.Show();
        }
    }
}
