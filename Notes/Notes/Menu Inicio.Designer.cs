﻿namespace Notes
{
    partial class Menu_Inicio
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
            this.nombreCuenta = new System.Windows.Forms.Label();
            this.Carrera = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.subirFoto = new System.Windows.Forms.Button();
            this.RutCuenta = new System.Windows.Forms.Label();
            this.Archivos = new System.Windows.Forms.Panel();
            this.ListaTodosArchivos = new System.Windows.Forms.ListBox();
            this.SubirArchivo = new System.Windows.Forms.Button();
            this.ListaArchivos = new System.Windows.Forms.ListBox();
            this.BtnArchivos = new System.Windows.Forms.Button();
            this.OtrosArchivos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Tipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.Archivos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreCuenta
            // 
            this.nombreCuenta.AutoSize = true;
            this.nombreCuenta.Font = new System.Drawing.Font("Gobold Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombreCuenta.Location = new System.Drawing.Point(50, 215);
            this.nombreCuenta.Name = "nombreCuenta";
            this.nombreCuenta.Size = new System.Drawing.Size(153, 28);
            this.nombreCuenta.TabIndex = 0;
            this.nombreCuenta.Text = "Nombre Cuenta";
            this.nombreCuenta.Click += new System.EventHandler(this.nombreCuenta_Click);
            // 
            // Carrera
            // 
            this.Carrera.AutoSize = true;
            this.Carrera.Font = new System.Drawing.Font("Gobold Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carrera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Carrera.Location = new System.Drawing.Point(50, 250);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(56, 17);
            this.Carrera.TabIndex = 1;
            this.Carrera.Text = "Carrera";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Gobold Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Email.Location = new System.Drawing.Point(50, 280);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 17);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // Foto
            // 
            this.Foto.InitialImage = null;
            this.Foto.Location = new System.Drawing.Point(50, 25);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(155, 155);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 3;
            this.Foto.TabStop = false;
            // 
            // subirFoto
            // 
            this.subirFoto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subirFoto.Font = new System.Drawing.Font("Quantify", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subirFoto.ForeColor = System.Drawing.Color.White;
            this.subirFoto.Location = new System.Drawing.Point(50, 160);
            this.subirFoto.Name = "subirFoto";
            this.subirFoto.Size = new System.Drawing.Size(60, 20);
            this.subirFoto.TabIndex = 4;
            this.subirFoto.Text = "Subir Foto";
            this.subirFoto.UseVisualStyleBackColor = true;
            this.subirFoto.Click += new System.EventHandler(this.subirFoto_Click);
            // 
            // RutCuenta
            // 
            this.RutCuenta.AutoSize = true;
            this.RutCuenta.Font = new System.Drawing.Font("Gobold Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RutCuenta.Location = new System.Drawing.Point(47, 183);
            this.RutCuenta.Name = "RutCuenta";
            this.RutCuenta.Size = new System.Drawing.Size(24, 14);
            this.RutCuenta.TabIndex = 5;
            this.RutCuenta.Text = "Rut";
            // 
            // Archivos
            // 
            this.Archivos.Controls.Add(this.ListaTodosArchivos);
            this.Archivos.Controls.Add(this.SubirArchivo);
            this.Archivos.Controls.Add(this.ListaArchivos);
            this.Archivos.Location = new System.Drawing.Point(276, 48);
            this.Archivos.Name = "Archivos";
            this.Archivos.Size = new System.Drawing.Size(512, 390);
            this.Archivos.TabIndex = 6;
            // 
            // ListaTodosArchivos
            // 
            this.ListaTodosArchivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListaTodosArchivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaTodosArchivos.Font = new System.Drawing.Font("Gobold Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaTodosArchivos.ForeColor = System.Drawing.Color.Black;
            this.ListaTodosArchivos.FormattingEnabled = true;
            this.ListaTodosArchivos.ItemHeight = 17;
            this.ListaTodosArchivos.Location = new System.Drawing.Point(0, 0);
            this.ListaTodosArchivos.Name = "ListaTodosArchivos";
            this.ListaTodosArchivos.Size = new System.Drawing.Size(512, 391);
            this.ListaTodosArchivos.TabIndex = 10;
            this.ListaTodosArchivos.SelectedIndexChanged += new System.EventHandler(this.ListaTodosArchivos_SelectedIndexChanged);
            // 
            // SubirArchivo
            // 
            this.SubirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubirArchivo.Font = new System.Drawing.Font("Quantify", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubirArchivo.ForeColor = System.Drawing.Color.White;
            this.SubirArchivo.Location = new System.Drawing.Point(4, 364);
            this.SubirArchivo.Name = "SubirArchivo";
            this.SubirArchivo.Size = new System.Drawing.Size(92, 23);
            this.SubirArchivo.TabIndex = 9;
            this.SubirArchivo.Text = "Subir Archivo";
            this.SubirArchivo.UseVisualStyleBackColor = true;
            this.SubirArchivo.Click += new System.EventHandler(this.SubirArchivo_Click);
            // 
            // ListaArchivos
            // 
            this.ListaArchivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListaArchivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaArchivos.Font = new System.Drawing.Font("Gobold Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaArchivos.ForeColor = System.Drawing.Color.Black;
            this.ListaArchivos.FormattingEnabled = true;
            this.ListaArchivos.ItemHeight = 17;
            this.ListaArchivos.Location = new System.Drawing.Point(0, 0);
            this.ListaArchivos.Name = "ListaArchivos";
            this.ListaArchivos.Size = new System.Drawing.Size(512, 391);
            this.ListaArchivos.TabIndex = 8;
            // 
            // BtnArchivos
            // 
            this.BtnArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArchivos.Font = new System.Drawing.Font("Gobold Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArchivos.ForeColor = System.Drawing.Color.White;
            this.BtnArchivos.Location = new System.Drawing.Point(276, 0);
            this.BtnArchivos.Name = "BtnArchivos";
            this.BtnArchivos.Size = new System.Drawing.Size(96, 48);
            this.BtnArchivos.TabIndex = 7;
            this.BtnArchivos.Text = "Mis Archivos";
            this.BtnArchivos.UseVisualStyleBackColor = true;
            this.BtnArchivos.Click += new System.EventHandler(this.BtnArchivos_Click);
            // 
            // OtrosArchivos
            // 
            this.OtrosArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OtrosArchivos.Font = new System.Drawing.Font("Gobold Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtrosArchivos.ForeColor = System.Drawing.Color.White;
            this.OtrosArchivos.Location = new System.Drawing.Point(373, 0);
            this.OtrosArchivos.Name = "OtrosArchivos";
            this.OtrosArchivos.Size = new System.Drawing.Size(136, 48);
            this.OtrosArchivos.TabIndex = 8;
            this.OtrosArchivos.Text = "Todos los Archivos";
            this.OtrosArchivos.UseVisualStyleBackColor = true;
            this.OtrosArchivos.Click += new System.EventHandler(this.OtrosArchivos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 26);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Font = new System.Drawing.Font("Gobold Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.Color.White;
            this.Cerrar.Location = new System.Drawing.Point(725, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 11;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Gobold Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.ForeColor = System.Drawing.Color.White;
            this.Tipo.Location = new System.Drawing.Point(50, 316);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(32, 17);
            this.Tipo.TabIndex = 10;
            this.Tipo.Text = "Tipo";
            // 
            // Menu_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.OtrosArchivos);
            this.Controls.Add(this.BtnArchivos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Archivos);
            this.Controls.Add(this.RutCuenta);
            this.Controls.Add(this.subirFoto);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Carrera);
            this.Controls.Add(this.nombreCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Inicio";
            this.Text = "Menu_Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.Archivos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreCuenta;
        private System.Windows.Forms.Label Carrera;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.Button subirFoto;
        private System.Windows.Forms.Label RutCuenta;
        private System.Windows.Forms.Panel Archivos;
        private System.Windows.Forms.Button BtnArchivos;
        private System.Windows.Forms.ListBox ListaArchivos;
        private System.Windows.Forms.Button SubirArchivo;
        private System.Windows.Forms.ListBox ListaTodosArchivos;
        private System.Windows.Forms.Button OtrosArchivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Button Cerrar;
    }
}