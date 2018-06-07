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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Cuenta));
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.TBxRut = new System.Windows.Forms.TextBox();
            this.TBxNombre = new System.Windows.Forms.TextBox();
            this.TBxApellido = new System.Windows.Forms.TextBox();
            this.TBxEmail = new System.Windows.Forms.TextBox();
            this.TBxContrasena = new System.Windows.Forms.TextBox();
            this.BtnRegIniciarSesion = new System.Windows.Forms.Button();
            this.carrera = new System.Windows.Forms.ComboBox();
            this.Letras = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.Location = new System.Drawing.Point(321, 340);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearCuenta.TabIndex = 0;
            this.BtnCrearCuenta.Text = "Crear Cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // TBxRut
            // 
            this.TBxRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxRut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBxRut.ForeColor = System.Drawing.Color.Gray;
            this.TBxRut.Location = new System.Drawing.Point(168, 55);
            this.TBxRut.Name = "TBxRut";
            this.TBxRut.Size = new System.Drawing.Size(228, 20);
            this.TBxRut.TabIndex = 1;
            this.TBxRut.Tag = "";
            this.TBxRut.Text = "Ingrese su Rut";
            this.TBxRut.TextChanged += new System.EventHandler(this.TBxRut_TextChanged);
            this.TBxRut.Enter += new System.EventHandler(this.TBxRut_Enter);
            this.TBxRut.Leave += new System.EventHandler(this.TBxRut_Leave);
            // 
            // TBxNombre
            // 
            this.TBxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxNombre.ForeColor = System.Drawing.Color.Gray;
            this.TBxNombre.Location = new System.Drawing.Point(168, 100);
            this.TBxNombre.Name = "TBxNombre";
            this.TBxNombre.Size = new System.Drawing.Size(228, 20);
            this.TBxNombre.TabIndex = 2;
            this.TBxNombre.Text = "Ingrese su Nombre";
            this.TBxNombre.Enter += new System.EventHandler(this.TBxNombre_Enter);
            this.TBxNombre.Leave += new System.EventHandler(this.TBxNombre_Leave);
            // 
            // TBxApellido
            // 
            this.TBxApellido.ForeColor = System.Drawing.Color.Gray;
            this.TBxApellido.Location = new System.Drawing.Point(168, 145);
            this.TBxApellido.Name = "TBxApellido";
            this.TBxApellido.Size = new System.Drawing.Size(228, 20);
            this.TBxApellido.TabIndex = 3;
            this.TBxApellido.Text = "Ingrese su Apellido";
            this.TBxApellido.Enter += new System.EventHandler(this.TBxApellido_Enter);
            this.TBxApellido.Leave += new System.EventHandler(this.TBxApellido_Leave);
            // 
            // TBxEmail
            // 
            this.TBxEmail.ForeColor = System.Drawing.Color.Gray;
            this.TBxEmail.Location = new System.Drawing.Point(168, 190);
            this.TBxEmail.Name = "TBxEmail";
            this.TBxEmail.Size = new System.Drawing.Size(228, 20);
            this.TBxEmail.TabIndex = 4;
            this.TBxEmail.Text = "Ingrese su Email";
            this.TBxEmail.Enter += new System.EventHandler(this.TBxEmail_Enter);
            this.TBxEmail.Leave += new System.EventHandler(this.TBxEmail_Leave);
            // 
            // TBxContrasena
            // 
            this.TBxContrasena.ForeColor = System.Drawing.Color.Gray;
            this.TBxContrasena.Location = new System.Drawing.Point(168, 235);
            this.TBxContrasena.Name = "TBxContrasena";
            this.TBxContrasena.Size = new System.Drawing.Size(228, 20);
            this.TBxContrasena.TabIndex = 5;
            this.TBxContrasena.Text = "Cree una Contraseña";
            this.TBxContrasena.Enter += new System.EventHandler(this.TBxContrasena_Enter);
            this.TBxContrasena.Leave += new System.EventHandler(this.TBxContrasena_Leave);
            // 
            // BtnRegIniciarSesion
            // 
            this.BtnRegIniciarSesion.Location = new System.Drawing.Point(168, 340);
            this.BtnRegIniciarSesion.Name = "BtnRegIniciarSesion";
            this.BtnRegIniciarSesion.Size = new System.Drawing.Size(75, 23);
            this.BtnRegIniciarSesion.TabIndex = 7;
            this.BtnRegIniciarSesion.Text = "Atras";
            this.BtnRegIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnRegIniciarSesion.Click += new System.EventHandler(this.BtnRegIniciarSesion_Click);
            // 
            // carrera
            // 
            this.carrera.ForeColor = System.Drawing.Color.Gray;
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
            this.carrera.Location = new System.Drawing.Point(168, 280);
            this.carrera.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(228, 21);
            this.carrera.TabIndex = 8;
            this.carrera.Text = "Seleccione una Carrera:";
            this.carrera.SelectedIndexChanged += new System.EventHandler(this.carrera_SelectedIndexChanged);
            this.carrera.Enter += new System.EventHandler(this.carrera_Enter);
            // 
            // Letras
            // 
            this.Letras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Letras.BackgroundImage")));
            this.Letras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Letras.Location = new System.Drawing.Point(0, 23);
            this.Letras.Name = "Letras";
            this.Letras.Size = new System.Drawing.Size(142, 365);
            this.Letras.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 26);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Font = new System.Drawing.Font("Gobold Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.Color.White;
            this.Cerrar.Location = new System.Drawing.Point(395, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 11;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Crear_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(470, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Letras);
            this.Controls.Add(this.carrera);
            this.Controls.Add(this.BtnRegIniciarSesion);
            this.Controls.Add(this.TBxContrasena);
            this.Controls.Add(this.TBxEmail);
            this.Controls.Add(this.TBxApellido);
            this.Controls.Add(this.TBxNombre);
            this.Controls.Add(this.TBxRut);
            this.Controls.Add(this.BtnCrearCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear_Cuenta";
            this.Text = "Crear_Cuenta";
            this.Load += new System.EventHandler(this.Crear_Cuenta_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Letras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cerrar;
    }
}