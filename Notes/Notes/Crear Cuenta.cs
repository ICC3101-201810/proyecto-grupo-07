using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Sistema CrearCuentaSistema = new Sistema();
            int Rut = Int32.Parse(TBxRut.Text);
            bool Verificacion = CrearCuentaSistema.VerificarCuenta(Rut);
            if (Verificacion==true)
            {
                CrearCuentaSistema.CrearCuenta(Rut, TBxNombre.Text, TBxApellido.Text, TBxContrasena.Text, TbxEmail.Text, TBxCarrera.Text);
                MessageBox.Show("Cuenta creada exitosamente");
            }
            if (Verificacion==false)
            {
                MessageBox.Show("No se pudo crear su cuenta");
            }
        }
    }
}
