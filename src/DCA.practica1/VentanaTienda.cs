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
        public static Usuario Sesion;

        public VentanaTienda(Usuario sesion)
        {
            Instancia = this;
            Sesion = sesion;
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
            Sesion = null;
            VentanaInicioSesion.Instancia.Show();
        }

        private void botonCarrito_Click(object sender, EventArgs e)
        {
            if (Sesion.Carrito.Count > 0)
            {
                VentanaCarrito ventana = new VentanaCarrito();
                ventana.Show();
                this.Hide();
            }
        }

        public static void RecargarVentanaTienda()
        {
            VentanaTienda.Instancia.VentanaTienda_Load(null, null);
        }

        private void VentanaTienda_Load(object sender, EventArgs e)
        {
            botonCarrito.Text = Sesion.Carrito.Count == 0 ? "Carrito" : "Carrito: " + Sesion.Carrito.Count;
        }
    }
}
