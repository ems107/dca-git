namespace DCA.practica1
{
    partial class VentanaCarrito
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
            this.vistaListaProductos = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPrecioTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vistaListaProductos
            // 
            this.vistaListaProductos.Location = new System.Drawing.Point(1, 0);
            this.vistaListaProductos.Name = "vistaListaProductos";
            this.vistaListaProductos.Size = new System.Drawing.Size(627, 449);
            this.vistaListaProductos.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(643, 304);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(135, 55);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total";
            // 
            // labelPrecioTotal
            // 
            this.labelPrecioTotal.AutoSize = true;
            this.labelPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioTotal.Location = new System.Drawing.Point(646, 370);
            this.labelPrecioTotal.Name = "labelPrecioTotal";
            this.labelPrecioTotal.Size = new System.Drawing.Size(111, 37);
            this.labelPrecioTotal.TabIndex = 2;
            this.labelPrecioTotal.Text = "Dinero";
            // 
            // VentanaCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrecioTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.vistaListaProductos);
            this.Name = "VentanaCarrito";
            this.Text = "VentanaCarrito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaCarrito_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel vistaListaProductos;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPrecioTotal;
    }
}