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
            this.vistaListaProductos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // vistaListaProductos
            // 
            this.vistaListaProductos.HideSelection = false;
            this.vistaListaProductos.Location = new System.Drawing.Point(1, 0);
            this.vistaListaProductos.Name = "vistaListaProductos";
            this.vistaListaProductos.Size = new System.Drawing.Size(799, 449);
            this.vistaListaProductos.TabIndex = 0;
            this.vistaListaProductos.UseCompatibleStateImageBehavior = false;
            // 
            // VentanaListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vistaListaProductos);
            this.Name = "VentanaListadoProductos";
            this.Text = "ListadoProductos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaListadoProductos_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView vistaListaProductos;
    }
}