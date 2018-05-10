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
    }
}
