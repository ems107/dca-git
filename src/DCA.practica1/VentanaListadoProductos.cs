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
    public partial class VentanaListadoProductos : Form
    {
        public static VentanaListadoProductos Instancia;

        public VentanaListadoProductos(IList<Producto> productos)
        {
            Instancia = this;
            InitializeComponent();
            CargarProductos(productos);
            labelCarrito.Text = "Carrito: " + VentanaTienda.Sesion.Carrito.Count.ToString();
        }

        private void CargarProductos(IList<Producto> productos)
        {
            int altura = 7;

            foreach(Producto producto in productos)
            {
                Button añadirProducto = new Button()
                {
                    Text = producto.ToString(),
                    Width = 200,
                    Location = new Point(0, altura)
            };

                añadirProducto.Click += (okSender, okEvents) =>
                { 
                    VentanaTienda.Sesion.Carrito.Add(producto);
                    labelCarrito.Text = "Carrito: " + VentanaTienda.Sesion.Carrito.Count.ToString();
                };

                vistaListaProductos.Controls.Add(añadirProducto);
                altura += añadirProducto.Height;
            }
        }

        private void VentanaListadoProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instancia = null;
            VentanaTienda.Instancia.Show();
        }
    }
}
