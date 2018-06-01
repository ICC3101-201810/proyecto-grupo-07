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
            this.TBxEmail = new System.Windows.Forms.TextBox();
            this.TBxContrasena = new System.Windows.Forms.TextBox();
            this.BtnRegIniciarSesion = new System.Windows.Forms.Button();
            this.carrera = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.Location = new System.Drawing.Point(428, 478);
            this.BtnCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(112, 35);
            this.BtnCrearCuenta.TabIndex = 0;
            this.BtnCrearCuenta.Text = "Crear Cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // TBxRut
            // 
            this.TBxRut.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TBxRut.Location = new System.Drawing.Point(151, 48);
            this.TBxRut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBxRut.Name = "TBxRut";
            this.TBxRut.Size = new System.Drawing.Size(340, 26);
            this.TBxRut.TabIndex = 1;
            this.TBxRut.Tag = "";
            this.TBxRut.Text = "Ingrese su Rut";
            this.TBxRut.TextChanged += new System.EventHandler(this.TBxRut_TextChanged);
            // 
            // TBxNombre
            // 
            this.TBxNombre.Location = new System.Drawing.Point(151, 109);
            this.TBxNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBxNombre.Name = "TBxNombre";
            this.TBxNombre.Size = new System.Drawing.Size(340, 26);
            this.TBxNombre.TabIndex = 2;
            this.TBxNombre.Text = "Ingrese su Nombre";
            // 
            // TBxApellido
            // 
            this.TBxApellido.Location = new System.Drawing.Point(151, 171);
            this.TBxApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBxApellido.Name = "TBxApellido";
            this.TBxApellido.Size = new System.Drawing.Size(340, 26);
            this.TBxApellido.TabIndex = 3;
            this.TBxApellido.Text = "Ingrese su Apellido";
            // 
            // TBxEmail
            // 
            this.TBxEmail.Location = new System.Drawing.Point(151, 239);
            this.TBxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBxEmail.Name = "TBxEmail";
            this.TBxEmail.Size = new System.Drawing.Size(340, 26);
            this.TBxEmail.TabIndex = 4;
            this.TBxEmail.Text = "Ingrese su Email";
            // 
            // TBxContrasena
            // 
            this.TBxContrasena.Location = new System.Drawing.Point(151, 304);
            this.TBxContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBxContrasena.Name = "TBxContrasena";
            this.TBxContrasena.Size = new System.Drawing.Size(340, 26);
            this.TBxContrasena.TabIndex = 5;
            this.TBxContrasena.Text = "Cree una Contraseña";
            // 
            // BtnRegIniciarSesion
            // 
            this.BtnRegIniciarSesion.Location = new System.Drawing.Point(97, 478);
            this.BtnRegIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRegIniciarSesion.Name = "BtnRegIniciarSesion";
            this.BtnRegIniciarSesion.Size = new System.Drawing.Size(112, 35);
            this.BtnRegIniciarSesion.TabIndex = 7;
            this.BtnRegIniciarSesion.Text = "Atras";
            this.BtnRegIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnRegIniciarSesion.Click += new System.EventHandler(this.BtnRegIniciarSesion_Click);
            // 
            // carrera
            // 
            this.carrera.FormattingEnabled = true;
            this.carrera.Items.AddRange(new object[] {
            "Administracion de Servicios",
            "Bachillerato de Enfermeria",
            "Bachillerato de Medicina",
            "Bachillerato de Obstetricia y Puericultura",
            "Bachillerato de Odontologia",
            "Bachillerato de Psicologia",
            "Bachillerato en Administracion de Servicios",
            "Bachillerato en Derecho",
            "Bachillerato en Humanidades",
            "Bachillerato en Ingenieria Civil",
            "Bachillerato en Ingenieria Comercial",
            "Bachillerato en Salud",
            "Comunicacion Audiovisual",
            "Derecho",
            "Educacion de Parvulos",
            "Enfermeria",
            "Filosofia",
            "Fonoaudiologia",
            "Historia",
            "Ingenieria Civil",
            "Ingenieria Comercial",
            "Kinesiologia",
            "Literatura",
            "Medicina",
            "Nutrición y Dietetica",
            "Obstetricia y Puericultura",
            "Odontologia",
            "Pedagogia Basica",
            "Pedagogia Basica Bilingue",
            "Pedagogia Media en Filosofia",
            "Pedagogia media en Historia y Ciencias Sociales",
            "Pedagogia Media en Lengua y Literatura",
            "Periodismo",
            "Psicologia",
            "Publicidad",
            "Terapia Ocupacional "});
            this.carrera.Location = new System.Drawing.Point(151, 369);
            this.carrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(340, 28);
            this.carrera.TabIndex = 8;
            this.carrera.Text = "Seleccione una Carrera:";
            this.carrera.SelectedIndexChanged += new System.EventHandler(this.carrera_SelectedIndexChanged);
            // 
            // Crear_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 579);
            this.Controls.Add(this.carrera);
            this.Controls.Add(this.BtnRegIniciarSesion);
            this.Controls.Add(this.TBxContrasena);
            this.Controls.Add(this.TBxEmail);
            this.Controls.Add(this.TBxApellido);
            this.Controls.Add(this.TBxNombre);
            this.Controls.Add(this.TBxRut);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Crear_Cuenta";
            this.Text = "Crear_Cuenta";
            this.Load += new System.EventHandler(this.Crear_Cuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.TextBox TBxRut;
        private System.Windows.Forms.TextBox TBxNombre;
        private System.Windows.Forms.TextBox TBxApellido;
        private System.Windows.Forms.TextBox TBxEmail;
        private System.Windows.Forms.TextBox TBxContrasena;
        private System.Windows.Forms.Button BtnRegIniciarSesion;
        private System.Windows.Forms.ComboBox carrera;
    }
}