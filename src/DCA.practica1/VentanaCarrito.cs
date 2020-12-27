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
    public partial class VentanaCarrito : Form
    {
        public static VentanaCarrito Instancia;

        public VentanaCarrito()
        {
            Instancia = this;
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            vistaListaProductos.Controls.Clear();
            int altura = 7;

            foreach (Producto producto in VentanaTienda.Sesion.Carrito)
            {
                Label detallesProducto = new Label()
                {
                    Text = producto.ToString() + ". Precio: " + producto.Precio.ToString() + "€",
                    Location = new Point(0, altura),
                    Width = 300,
                    MaximumSize = new Size(300, 20)
                };

                Button eliminarProducto = new Button()
                {
                    Text = "Borrar",
                    Location = new Point(detallesProducto.Width, altura)
                };

                eliminarProducto.Click += (okSender, okEvents) =>
                {
                    VentanaTienda.Sesion.Carrito.Remove(producto);
                    CargarProductos();
                };

                vistaListaProductos.Controls.Add(detallesProducto);
                vistaListaProductos.Controls.Add(eliminarProducto);
                altura += 30;
            }
        }

        private void VentanaCarrito_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instancia = null;
            VentanaTienda.Instancia.Show();
        }
    }
}
