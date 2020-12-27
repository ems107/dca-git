namespace DCA.practica1
{
    partial class VentanaRegistrar
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
            this.entradaNombreUsuario = new System.Windows.Forms.TextBox();
            this.entradaContraseña = new System.Windows.Forms.TextBox();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entradaNombreUsuario
            // 
            this.entradaNombreUsuario.Location = new System.Drawing.Point(249, 94);
            this.entradaNombreUsuario.Name = "entradaNombreUsuario";
            this.entradaNombreUsuario.Size = new System.Drawing.Size(288, 20);
            this.entradaNombreUsuario.TabIndex = 0;
            // 
            // entradaContraseña
            // 
            this.entradaContraseña.Location = new System.Drawing.Point(249, 214);
            this.entradaContraseña.Name = "entradaContraseña";
            this.entradaContraseña.Size = new System.Drawing.Size(288, 20);
            this.entradaContraseña.TabIndex = 1;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(339, 304);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(110, 23);
            this.botonRegistrar.TabIndex = 2;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(348, 69);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(81, 13);
            this.labelNombreUsuario.TabIndex = 3;
            this.labelNombreUsuario.Text = "Nombre usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(359, 188);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 4;
            this.labelContraseña.Text = "Contraseña";
            // 
            // VentanaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.entradaContraseña);
            this.Controls.Add(this.entradaNombreUsuario);
            this.Name = "VentanaRegistrar";
            this.Text = "VentanaRegistrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entradaNombreUsuario;
        private System.Windows.Forms.TextBox entradaContraseña;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelContraseña;
    }
}