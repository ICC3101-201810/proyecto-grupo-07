﻿namespace Notes
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
            this.Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // TBxRut
            // 
            this.TBxRut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.TBxRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxRut.Cursor = System.Windows.Forms.Cursors.Default;
            this.TBxRut.Font = new System.Drawing.Font("Quantify", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBxRut.ForeColor = System.Drawing.Color.White;
            this.TBxRut.Location = new System.Drawing.Point(65, 93);
            this.TBxRut.Name = "TBxRut";
            this.TBxRut.Size = new System.Drawing.Size(134, 19);
            this.TBxRut.TabIndex = 0;
            this.TBxRut.Text = "RUT";
            this.TBxRut.TextChanged += new System.EventHandler(this.TBxRut_TextChanged);
            this.TBxRut.Enter += new System.EventHandler(this.TBxRut_Enter);
            this.TBxRut.Leave += new System.EventHandler(this.TBxRut_Leave);
            // 
            // TBxContrasena
            // 
            this.TBxContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.TBxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxContrasena.Font = new System.Drawing.Font("Quantify", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBxContrasena.ForeColor = System.Drawing.Color.White;
            this.TBxContrasena.Location = new System.Drawing.Point(65, 118);
            this.TBxContrasena.Name = "TBxContrasena";
            this.TBxContrasena.Size = new System.Drawing.Size(134, 19);
            this.TBxContrasena.TabIndex = 1;
            this.TBxContrasena.Text = "CONTRASEÑA";
            this.TBxContrasena.Enter += new System.EventHandler(this.TBxContrasena_Enter);
            this.TBxContrasena.Leave += new System.EventHandler(this.TBxContrasena_Leave);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.BtnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Quantify", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(65, 168);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(134, 23);
            this.BtnIniciarSesion.TabIndex = 2;
            this.BtnIniciarSesion.Text = "Iniciar Sesion";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.BtnCrearCuenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCuenta.Font = new System.Drawing.Font("Quantify", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCuenta.Location = new System.Drawing.Point(65, 197);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(134, 23);
            this.BtnCrearCuenta.TabIndex = 3;
            this.BtnCrearCuenta.Text = "Crear Cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = false;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.ErrorImage = null;
            this.Fondo.InitialImage = null;
            this.Fondo.Location = new System.Drawing.Point(0, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(284, 261);
            this.Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo.TabIndex = 4;
            this.Fondo.TabStop = false;
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TBxContrasena);
            this.Controls.Add(this.TBxRut);
            this.Controls.Add(this.Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio_Sesion";
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.Inicio_Sesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBxRut;
        private System.Windows.Forms.TextBox TBxContrasena;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.PictureBox Fondo;
    }
}

