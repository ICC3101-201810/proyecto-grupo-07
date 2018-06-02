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

namespace Notes
{
    public partial class Inicio_Sesion : Form
    {
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
            if (TBxRut.Text == "RUT")
            {
                TBxRut.Text = "";
                TBxRut.ForeColor = Color.LightBlue;
            }
        }

        private void TBxRut_Leave(object sender, EventArgs e)
        {
            if (TBxRut.Text=="")
            {
                TBxRut.Text = "RUT";
            }
        }

        private void TBxContrasena_Enter(object sender, EventArgs e)
        {
            if (TBxContrasena.Text == "CONTRASEÑA")
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
                TBxContrasena.Text = "CONTRASEÑA";
                TBxContrasena.UseSystemPasswordChar = false;
            }
        }
    }
}
