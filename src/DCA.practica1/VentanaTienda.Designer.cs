namespace DCA.practica1
{
    partial class VentanaTienda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonVideojuegos = new System.Windows.Forms.Button();
            this.botonPortatiles = new System.Windows.Forms.Button();
            this.botonDispositivosMoviles = new System.Windows.Forms.Button();
            this.botonCarrito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonVideojuegos
            // 
            this.botonVideojuegos.Location = new System.Drawing.Point(134, 92);
            this.botonVideojuegos.Name = "botonVideojuegos";
            this.botonVideojuegos.Size = new System.Drawing.Size(75, 23);
            this.botonVideojuegos.TabIndex = 0;
            this.botonVideojuegos.Text = "Videojuegos";
            this.botonVideojuegos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonVideojuegos.UseVisualStyleBackColor = true;
            this.botonVideojuegos.Click += new System.EventHandler(this.botonVideojuegos_Click);
            // 
            // botonPortatiles
            // 
            this.botonPortatiles.Location = new System.Drawing.Point(351, 92);
            this.botonPortatiles.Name = "botonPortatiles";
            this.botonPortatiles.Size = new System.Drawing.Size(75, 23);
            this.botonPortatiles.TabIndex = 1;
            this.botonPortatiles.Text = "Portatiles";
            this.botonPortatiles.UseVisualStyleBackColor = true;
            this.botonPortatiles.Click += new System.EventHandler(this.botonPortatiles_Click);
            // 
            // botonDispositivosMoviles
            // 
            this.botonDispositivosMoviles.Location = new System.Drawing.Point(548, 92);
            this.botonDispositivosMoviles.Name = "botonDispositivosMoviles";
            this.botonDispositivosMoviles.Size = new System.Drawing.Size(116, 23);
            this.botonDispositivosMoviles.TabIndex = 2;
            this.botonDispositivosMoviles.Text = "Dispositivos Moviles";
            this.botonDispositivosMoviles.UseVisualStyleBackColor = true;
            this.botonDispositivosMoviles.Click += new System.EventHandler(this.botonDispositivosMoviles_Click);
            // 
            // botonCarrito
            // 
            this.botonCarrito.Location = new System.Drawing.Point(12, 395);
            this.botonCarrito.Name = "botonCarrito";
            this.botonCarrito.Size = new System.Drawing.Size(144, 43);
            this.botonCarrito.TabIndex = 3;
            this.botonCarrito.Text = "Carrito";
            this.botonCarrito.UseVisualStyleBackColor = true;
            this.botonCarrito.Click += new System.EventHandler(this.botonCarrito_Click);
            // 
            // VentanaTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCarrito);
            this.Controls.Add(this.botonDispositivosMoviles);
            this.Controls.Add(this.botonPortatiles);
            this.Controls.Add(this.botonVideojuegos);
            this.Name = "VentanaTienda";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaTienda_FormClosing);
            this.Load += new System.EventHandler(this.VentanaTienda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVideojuegos;
        private System.Windows.Forms.Button botonPortatiles;
        private System.Windows.Forms.Button botonDispositivosMoviles;
        private System.Windows.Forms.Button botonCarrito;
    }
}

