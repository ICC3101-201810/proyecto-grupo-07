namespace Notes
{
    partial class Inicio_Sesion
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
            this.TBxRut = new System.Windows.Forms.TextBox();
            this.TBxContrasena = new System.Windows.Forms.TextBox();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBxRut
            // 
            this.TBxRut.Location = new System.Drawing.Point(123, 92);
            this.TBxRut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBxRut.Name = "TBxRut";
            this.TBxRut.Size = new System.Drawing.Size(148, 26);
            this.TBxRut.TabIndex = 0;
            this.TBxRut.Text = "Rut";
            this.TBxRut.TextChanged += new System.EventHandler(this.TBxRut_TextChanged);
            // 
            // TBxContrasena
            // 
            this.TBxContrasena.Location = new System.Drawing.Point(123, 155);
            this.TBxContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBxContrasena.Name = "TBxContrasena";
            this.TBxContrasena.PasswordChar = '*';
            this.TBxContrasena.Size = new System.Drawing.Size(148, 26);
            this.TBxContrasena.TabIndex = 1;
            this.TBxContrasena.Text = "Contraseña";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(123, 258);
            this.BtnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(150, 35);
            this.BtnIniciarSesion.TabIndex = 2;
            this.BtnIniciarSesion.Text = "Iniciar Sesion";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.Location = new System.Drawing.Point(123, 303);
            this.BtnCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(150, 35);
            this.BtnCrearCuenta.TabIndex = 3;
            this.BtnCrearCuenta.Text = "Crear Cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TBxContrasena);
            this.Controls.Add(this.TBxRut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio_Sesion";
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.Inicio_Sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBxRut;
        private System.Windows.Forms.TextBox TBxContrasena;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnCrearCuenta;
    }
}

