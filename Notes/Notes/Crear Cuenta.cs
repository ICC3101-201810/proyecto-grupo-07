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
    public partial class Crear_Cuenta : Form
    {
        public Crear_Cuenta()
        {
            InitializeComponent();
        }

        private void BtnRegIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio_Sesion inicio_Sesion = new Inicio_Sesion();
            inicio_Sesion.Show();
        }

        private void TBxRut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            string Rut = TBxRut.Text;
            string Nombre = TBxNombre.Text;
            string Apellido = TBxApellido.Text;
            string Email = TBxEmail.Text;
            string Contrasena = TBxContrasena.Text;
            string Carrera = TBxCarrera.Text;

            string Url = Rut + ".txt";

            if (File.Exists(Url))
            {
                MessageBox.Show("Este usuario ya se encuentra registrado");
            }

            else
            {
                Sistema CifrarContrasena = new Sistema();
                string ContrasenaCifrada = CifrarContrasena.CifrarContrasena(Contrasena);
                File.WriteAllText(Url,Rut+"_"+Nombre+"_"+Apellido+"_"+Email+"_"+ContrasenaCifrada+"_"+Carrera);

                MessageBox.Show("Su Usuario se Registro Correctamente");
            }
        }
    }
}
