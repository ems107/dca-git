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
        }

        private void CargarProductos(IList<Producto> productos)
        {
            foreach(Producto producto in productos)
            {
                vistaListaProductos.Items.Add(producto.ToString());
            }
        }
    }
}
