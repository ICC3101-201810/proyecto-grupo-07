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
    public partial class Crear_Cuenta : Form
    {

        public Crear_Cuenta()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void Releasecapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

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
            if (TBxRut.Text != "Ingrese su Rut")
            {
                string Rut = TBxRut.Text;


                if (TBxNombre.Text != "Ingrese su Nombre")
                {
                    string Nombre = TBxNombre.Text;
                    if (TBxApellido.Text != "Ingrese su Apellido")
                    {
                        string Apellido = TBxApellido.Text;
                        if (TBxEmail.Text != "Ingrese su Email")
                        {
                            string Email = TBxEmail.Text;
                            
                            if (TBxContrasena.Text != "Cree una Contraseña")
                            {
                                string Contrasena = TBxContrasena.Text;
                                if (carrera.Text != "Seleccione una Carrera:")
                                {
                                    string Url = Rut + ".txt";

                                    if (File.Exists(Url))
                                    {
                                        MessageBox.Show("Este usuario ya se encuentra registrado");
                                    }

                                    else
                                    {
                                        Sistema CifrarContrasena = new Sistema();
                                        string ContrasenaCifrada = CifrarContrasena.CifrarContrasena(Contrasena);
                                        File.WriteAllText(Url, Rut + "_*" + Nombre + "_*" + Apellido + "_*" + Email + "_*" + ContrasenaCifrada + "_*" + carrera.Text);

                                        MessageBox.Show("Su Usuario se Registro Correctamente");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No ha seleccionado carrera");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No ha creado una contaseña");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No ha ingresado su email");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ha ingresado su Apellido");
                    }
                }
                else
                {
                    MessageBox.Show("No ha ingresado su Nombre");
                }
            }
            else
            {
                MessageBox.Show("No ha ingresado su Rut");
            }

        }

        private void carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Crear_Cuenta_Load(object sender, EventArgs e)
        {

        }

        private void TBxRut_Enter(object sender, EventArgs e)
        {
            if (TBxRut.Text == "Ingrese su Rut")
            {
                TBxRut.Text = "";
                TBxRut.ForeColor = Color.Black;
            }
        }

        private void TBxRut_Leave(object sender, EventArgs e)
        {
            if (TBxRut.Text == "")
            {
                TBxRut.Text = "Ingrese su Rut";
                TBxRut.ForeColor = Color.Gray;
            }
            else
            {
                char[] Partes = TBxRut.Text.ToArray();

                string Rut = "";

                foreach (char numero in Partes)
                {
                    string numeros = Convert.ToString(numero);

                    if (numeros == "1" || numeros == "2" || numeros == "3" || numeros == "4" ||
                        numeros == "5" || numeros == "6" || numeros == "7" || numeros == "8" ||
                        numeros == "9" || numeros == "0")
                    {
                        Rut = Rut + numeros;
                    }
                }
                TBxRut.Text = Rut;
            }
            
        }

        private void TBxNombre_Enter(object sender, EventArgs e)
        {
            if (TBxNombre.Text == "Ingrese su Nombre")
            {
                TBxNombre.Text = "";
                TBxNombre.ForeColor = Color.Black;
            }
        }

        private void TBxNombre_Leave(object sender, EventArgs e)
        {
            if (TBxNombre.Text == "")
            {
                TBxNombre.Text = "Ingrese su Nombre";
                TBxNombre.ForeColor = Color.Gray;
            }
        }

        private void TBxApellido_Enter(object sender, EventArgs e)
        {
            if (TBxApellido.Text == "Ingrese su Apellido")
            {
                TBxApellido.Text = "";
                TBxApellido.ForeColor = Color.Black;
            }
        }

        private void TBxApellido_Leave(object sender, EventArgs e)
        {
            if (TBxApellido.Text == "")
            {
                TBxApellido.Text = "Ingrese su Apellido";
                TBxApellido.ForeColor = Color.Gray;
            }
        }

        private void TBxEmail_Enter(object sender, EventArgs e)
        {
            if (TBxEmail.Text == "Ingrese su Email")
            {
                TBxEmail.Text = "";
                TBxEmail.ForeColor = Color.Black;
            }
        }

        private void TBxEmail_Leave(object sender, EventArgs e)
        {
            if (TBxEmail.Text == "")
            {
                TBxEmail.Text = "Ingrese su Email";
                TBxEmail.ForeColor = Color.Gray;
            }
            string Separador = "@";

            char Sep = Convert.ToChar(Separador);

            string[] Partes = TBxEmail.Text.Split(Sep);

            if (Partes.Length == 2)
            {
                if (Partes[1].ToUpper() == "MIUANDES.CL")
                {
                    TBxEmail.Text = Partes[0] + "@miuandes.cl";
                }
                else
                {
                    MessageBox.Show("Solo se aceptan email miuandes.cl");
                }
            }
          
            else
            {
                MessageBox.Show("El correo ingresado no es correcto");
            }
        }

        private void TBxContrasena_Enter(object sender, EventArgs e)
        {
            if (TBxContrasena.Text == "Cree una Contraseña")
            {
                TBxContrasena.Text = "";
                TBxContrasena.ForeColor = Color.Black;
            }
        }

        private void TBxContrasena_Leave(object sender, EventArgs e)
        {
            if (TBxContrasena.Text == "")
            {
                TBxContrasena.Text = "Cree una Contraseña";
                TBxContrasena.ForeColor = Color.Gray;
            }
        }

        private void carrera_Enter(object sender, EventArgs e)
        {
            if (carrera.Text == "Seleccione una Carrera")
            {
                carrera.Text = "";
                carrera.ForeColor = Color.Black;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Releasecapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
