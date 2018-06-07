using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Notes
{
    public partial class Inicio_Sesion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void Releasecapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crear_Cuenta crear_Cuenta = new Crear_Cuenta();
            crear_Cuenta.Show();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string Rut = TBxRut.Text;
            string Contrasena = TBxContrasena.Text;

            string Url = Rut + ".txt";

            if (File.Exists(Url))
            {
                Sistema InstanciaSistema = new Sistema();

                bool Resultado = InstanciaSistema.VerificarContrasena(Rut, Contrasena);

                if (Resultado == true)
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido");
                    Menu_Inicio menu_Inicio = new Menu_Inicio(Rut);
                    menu_Inicio.Show();

                }
                else if (Resultado == false)
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El Rut ingresado no se encuentra registrado");

            }
        }

        private void TBxRut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {

        }

        private void TBxRut_Enter(object sender, EventArgs e)
        {
            if (TBxRut.Text == "Rut")
            {
                TBxRut.Text = "";
                TBxRut.ForeColor = Color.LightBlue;
            }
        }

        private void TBxRut_Leave(object sender, EventArgs e)
        {
            if (TBxRut.Text=="")
            {
                TBxRut.Text = "Rut";
            }
        }

        private void TBxContrasena_Enter(object sender, EventArgs e)
        {
            if (TBxContrasena.Text == "Contraseña")
            {
                TBxContrasena.Text = "";
                TBxContrasena.ForeColor = Color.LightBlue;
                TBxContrasena.UseSystemPasswordChar = true;
            }
        }

        private void TBxContrasena_Leave(object sender, EventArgs e)
        {
            if (TBxContrasena.Text == "")
            {
                TBxContrasena.Text = "Contraseña";
                TBxContrasena.UseSystemPasswordChar = false;
            }
        }

        private void Fondo_MouseDown(object sender, MouseEventArgs e)
        {
            Releasecapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
