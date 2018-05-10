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
            this.TBxNombre = new System.Windows.Forms.TextBox();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBxRut
            // 
            this.TBxRut.Location = new System.Drawing.Point(82, 60);
            this.TBxRut.Name = "TBxRut";
            this.TBxRut.Size = new System.Drawing.Size(100, 20);
            this.TBxRut.TabIndex = 0;
            this.TBxRut.Text = "Rut";
            // 
            // TBxNombre
            // 
            this.TBxNombre.Location = new System.Drawing.Point(82, 101);
            this.TBxNombre.Name = "TBxNombre";
            this.TBxNombre.PasswordChar = '*';
            this.TBxNombre.Size = new System.Drawing.Size(100, 20);
            this.TBxNombre.TabIndex = 1;
            this.TBxNombre.Text = "Contraseña";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(82, 168);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(100, 23);
            this.BtnIniciarSesion.TabIndex = 2;
            this.BtnIniciarSesion.Text = "Iniciar Sesion";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.Location = new System.Drawing.Point(82, 197);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(100, 23);
            this.BtnCrearCuenta.TabIndex = 3;
            this.BtnCrearCuenta.Text = "Crear Cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TBxNombre);
            this.Controls.Add(this.TBxRut);
            this.Name = "Inicio_Sesion";
            this.Text = "Inicio Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBxRut;
        private System.Windows.Forms.TextBox TBxNombre;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnCrearCuenta;
    }
}

