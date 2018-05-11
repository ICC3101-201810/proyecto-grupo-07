namespace Notes
{
    partial class Crear_Cuenta
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
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.TBxRut = new System.Windows.Forms.TextBox();
            this.TBxNombre = new System.Windows.Forms.TextBox();
            this.TBxApellido = new System.Windows.Forms.TextBox();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.TBxContrasena = new System.Windows.Forms.TextBox();
            this.TBxCarrera = new System.Windows.Forms.TextBox();
            this.BtnRegIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.Location = new System.Drawing.Point(225, 310);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearCuenta.TabIndex = 0;
            this.BtnCrearCuenta.Text = "Crear Cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // TBxRut
            // 
            this.TBxRut.Location = new System.Drawing.Point(139, 38);
            this.TBxRut.Name = "TBxRut";
            this.TBxRut.Size = new System.Drawing.Size(100, 20);
            this.TBxRut.TabIndex = 1;
            this.TBxRut.Tag = "";
            this.TBxRut.TextChanged += new System.EventHandler(this.TBxRut_TextChanged);
            // 
            // TBxNombre
            // 
            this.TBxNombre.Location = new System.Drawing.Point(139, 77);
            this.TBxNombre.Name = "TBxNombre";
            this.TBxNombre.Size = new System.Drawing.Size(100, 20);
            this.TBxNombre.TabIndex = 2;
            this.TBxNombre.Text = "Nombre";
            // 
            // TBxApellido
            // 
            this.TBxApellido.Location = new System.Drawing.Point(139, 120);
            this.TBxApellido.Name = "TBxApellido";
            this.TBxApellido.Size = new System.Drawing.Size(100, 20);
            this.TBxApellido.TabIndex = 3;
            this.TBxApellido.Text = "Apellido";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(139, 157);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(100, 20);
            this.TbxEmail.TabIndex = 4;
            this.TbxEmail.Text = "Email";
            // 
            // TBxContrasena
            // 
            this.TBxContrasena.Location = new System.Drawing.Point(139, 197);
            this.TBxContrasena.Name = "TBxContrasena";
            this.TBxContrasena.Size = new System.Drawing.Size(100, 20);
            this.TBxContrasena.TabIndex = 5;
            this.TBxContrasena.Text = "Contrasena";
            // 
            // TBxCarrera
            // 
            this.TBxCarrera.Location = new System.Drawing.Point(139, 235);
            this.TBxCarrera.Name = "TBxCarrera";
            this.TBxCarrera.Size = new System.Drawing.Size(100, 20);
            this.TBxCarrera.TabIndex = 6;
            this.TBxCarrera.Text = "Carrera";
            // 
            // BtnRegIniciarSesion
            // 
            this.BtnRegIniciarSesion.Location = new System.Drawing.Point(102, 310);
            this.BtnRegIniciarSesion.Name = "BtnRegIniciarSesion";
            this.BtnRegIniciarSesion.Size = new System.Drawing.Size(75, 23);
            this.BtnRegIniciarSesion.TabIndex = 7;
            this.BtnRegIniciarSesion.Text = "Atras";
            this.BtnRegIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnRegIniciarSesion.Click += new System.EventHandler(this.BtnRegIniciarSesion_Click);
            // 
            // Crear_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 376);
            this.Controls.Add(this.BtnRegIniciarSesion);
            this.Controls.Add(this.TBxCarrera);
            this.Controls.Add(this.TBxContrasena);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.TBxApellido);
            this.Controls.Add(this.TBxNombre);
            this.Controls.Add(this.TBxRut);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Name = "Crear_Cuenta";
            this.Text = "Crear_Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.TextBox TBxRut;
        private System.Windows.Forms.TextBox TBxNombre;
        private System.Windows.Forms.TextBox TBxApellido;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.TextBox TBxContrasena;
        private System.Windows.Forms.TextBox TBxCarrera;
        private System.Windows.Forms.Button BtnRegIniciarSesion;
    }
}