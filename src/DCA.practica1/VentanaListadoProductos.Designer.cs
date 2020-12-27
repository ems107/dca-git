namespace DCA.practica1
{
    partial class VentanaListadoProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCarrito = new System.Windows.Forms.Label();
            this.vistaListaProductos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelCarrito
            // 
            this.labelCarrito.AutoSize = true;
            this.labelCarrito.Location = new System.Drawing.Point(13, 425);
            this.labelCarrito.Name = "labelCarrito";
            this.labelCarrito.Size = new System.Drawing.Size(40, 13);
            this.labelCarrito.TabIndex = 2;
            this.labelCarrito.Text = "Carrito:";
            // 
            // vistaListaProductos
            // 
            this.vistaListaProductos.Location = new System.Drawing.Point(2, 1);
            this.vistaListaProductos.Name = "vistaListaProductos";
            this.vistaListaProductos.Size = new System.Drawing.Size(797, 421);
            this.vistaListaProductos.TabIndex = 3;
            // 
            // VentanaListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vistaListaProductos);
            this.Controls.Add(this.labelCarrito);
            this.Name = "VentanaListadoProductos";
            this.Text = "ListadoProductos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaListadoProductos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCarrito;
        private System.Windows.Forms.Panel vistaListaProductos;
    }
}