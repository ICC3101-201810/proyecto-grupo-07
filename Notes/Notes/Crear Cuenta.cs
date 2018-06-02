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
                                        File.WriteAllText(Url, Rut + "_" + Nombre + "_" + Apellido + "_" + Email + "_" + ContrasenaCifrada + "_" + carrera.Text);

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
    }
}
