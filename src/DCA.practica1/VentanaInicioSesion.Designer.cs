namespace DCA.practica1
{
    partial class VentanaInicioSesion
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
            this.botonInicioSesion = new System.Windows.Forms.Button();
            this.entradaUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.entradaContraseña = new System.Windows.Forms.TextBox();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonInicioSesion
            // 
            this.botonInicioSesion.Location = new System.Drawing.Point(172, 277);
            this.botonInicioSesion.Name = "botonInicioSesion";
            this.botonInicioSesion.Size = new System.Drawing.Size(98, 23);
            this.botonInicioSesion.TabIndex = 0;
            this.botonInicioSesion.Text = "Inicio Sesión";
            this.botonInicioSesion.UseVisualStyleBackColor = true;
            this.botonInicioSesion.Click += new System.EventHandler(this.botonInicioSesion_Click);
            // 
            // entradaUsuario
            // 
            this.entradaUsuario.Location = new System.Drawing.Point(172, 124);
            this.entradaUsuario.Name = "entradaUsuario";
            this.entradaUsuario.Size = new System.Drawing.Size(439, 20);
            this.entradaUsuario.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(172, 105);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(172, 173);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña";
            // 
            // entradaContraseña
            // 
            this.entradaContraseña.Location = new System.Drawing.Point(172, 198);
            this.entradaContraseña.Name = "entradaContraseña";
            this.entradaContraseña.Size = new System.Drawing.Size(439, 20);
            this.entradaContraseña.TabIndex = 4;
            this.entradaContraseña.UseSystemPasswordChar = true;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(521, 277);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(90, 23);
            this.botonRegistrar.TabIndex = 5;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // VentanaInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.entradaContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.entradaUsuario);
            this.Controls.Add(this.botonInicioSesion);
            this.Name = "VentanaInicioSesion";
            this.Text = "VentanaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonInicioSesion;
        private System.Windows.Forms.TextBox entradaUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox entradaContraseña;
        private System.Windows.Forms.Button botonRegistrar;
    }
}