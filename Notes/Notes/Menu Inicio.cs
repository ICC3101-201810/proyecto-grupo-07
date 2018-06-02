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
    public partial class Menu_Inicio : Form
    {
        public Menu_Inicio(string Rut)
        {
            InitializeComponent();


            string[] LineasTexto = File.ReadAllLines(Rut + ".txt");

            string Separador = "_";
            char Sep = Convert.ToChar(Separador);
            string[] Atributos = LineasTexto[0].Split(Sep);

            RutCuenta.Text = Atributos[0];
            nombreCuenta.Text = Atributos[1] + " " + Atributos[2];
            Carrera.Text = Atributos[5];
            Email.Text = Atributos[3];

            string url = "../Fotos/" + Atributos[0] + ".jpg";

            if (File.Exists(url))
            {
                Foto.ImageLocation = url;
            }
            else
            {
                Foto.ImageLocation = "../Fotos/Foto.png";
            }
        }

        private void Menu_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void nombreCuenta_Click(object sender, EventArgs e)
        {

        }

        private void subirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string NombreArchivo = openFile.FileName;

                string Directorio = "../Fotos/" + RutCuenta.Text + ".jpg";

                File.Copy(openFile.FileName, Directorio, true);

                string url = "../Fotos/" + RutCuenta.Text + ".jpg";

                Foto.ImageLocation = url;

            }

        }

        private void BtnArchivos_Click(object sender, EventArgs e)
        {
            ListaArchivos.Visible = true;
            ListaTodosArchivos.Visible = false;
            SubirArchivo.Visible = true;
            ListaArchivos.Items.Clear();

            string[] Publicospdf = Directory.GetFiles("../Archivos/", "*"+RutCuenta.Text+"pu.pdf");
            string[] Privadospdf = Directory.GetFiles("../Archivos/", "*"+RutCuenta.Text + "pr.pdf");
            string[] Publicosjpg = Directory.GetFiles("../Archivos/", "*" + RutCuenta.Text + "pu.jpg");
            string[] Privadosjpg = Directory.GetFiles("../Archivos/", "*" + RutCuenta.Text + "pr.jpg");
            string[] Publicosdoc = Directory.GetFiles("../Archivos/", "*" + RutCuenta.Text + "pu.doc");
            string[] Privadosdoc = Directory.GetFiles("../Archivos/", "*" + RutCuenta.Text + "pr.doc");
            string[] Publicostxt = Directory.GetFiles("../Archivos/", "*" + RutCuenta.Text + "pu.txt");
            string[] Privadostxt = Directory.GetFiles("../Archivos/", "*" + RutCuenta.Text + "pr.txt");

            if (Publicospdf.Length == 0 && Publicosjpg.Length == 0 && Publicosdoc.Length == 0 && Publicostxt.Length == 0
                && Privadospdf.Length == 0 && Privadosjpg.Length == 0 && Privadosdoc.Length == 0 && Privadostxt.Length == 0)
            {
                ListaArchivos.Items.Add("No hay archivos subidos por ti en el sistema");
            }

            else
            {

                foreach (string ArchivosPublicospdf in Publicospdf)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPublicospdf.Split(Sep);

                    ListaArchivos.Items.Add(Partes[2] + " Publico");
                }
                foreach (string ArchivosPublicosjpg in Publicosjpg)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPublicosjpg.Split(Sep);

                    ListaArchivos.Items.Add(Partes[2] + " Publico");
                }
                foreach (string ArchivosPublicosdoc in Publicosdoc)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPublicosdoc.Split(Sep);

                    ListaArchivos.Items.Add(Partes[2] + " Publico");
                }
                foreach (string ArchivosPublicostxt in Publicostxt)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPublicostxt.Split(Sep);

                    ListaArchivos.Items.Add(Partes[2] + " Publico");
                }

                foreach (string ArchivosPrivadospdf in Privadospdf)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPrivadospdf.Split(Sep);
                    ListaArchivos.Items.Add(Partes[2] + " Privado");
                }
                foreach (string ArchivosPrivadosjpg in Privadosjpg)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPrivadosjpg.Split(Sep);
                    ListaArchivos.Items.Add(Partes[2] + " Privado");
                }
                foreach (string ArchivosPrivadosdoc in Privadosdoc)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPrivadosdoc.Split(Sep);
                    ListaArchivos.Items.Add(Partes[2] + " Privado");
                }
                foreach (string ArchivosPrivadostxt in Privadostxt)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPrivadostxt.Split(Sep);
                    ListaArchivos.Items.Add(Partes[2] + " Privado");
                }

            }

            ListaArchivos.Show();
        }

        private void ListaArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string NombreArchivo = openFile.FileName;

                string Separador = @".";
                string Separador2 = @"\";
                char Sep = Convert.ToChar(Separador);
                char Sep2 = Convert.ToChar(Separador2);
                string[] Partes = NombreArchivo.Split(Sep);
                string[] Partes2 = NombreArchivo.Split(Sep2);

                string nomArchivo = Partes[Partes.Length - 1];
                string nomArchivo2 = Partes2[Partes2.Length - 1];

                string Directorio = "../Archivos/" + nomArchivo2 + RutCuenta.Text +"pu."+ nomArchivo;
                if (File.Exists(Directorio))
                {
                    MessageBox.Show("Ya existe un archivo con el mismo nombre");

                }
                else
                {
                    File.Copy(openFile.FileName, Directorio, true);

                    MessageBox.Show("Subio el archivo con exito");
                }

            }
        }

        private void OtrosArchivos_Click(object sender, EventArgs e)
        {
            ListaArchivos.Visible = false;
            ListaTodosArchivos.Visible = true;
            SubirArchivo.Visible = false;

            ListaTodosArchivos.Items.Clear();

            string[] Publicospdf = Directory.GetFiles("../Archivos/", "*pu.pdf");
 
            string[] Publicosjpg = Directory.GetFiles("../Archivos/", "*pu.jpg");

            string[] Publicosdoc = Directory.GetFiles("../Archivos/", "*pu.doc");

            string[] Publicostxt = Directory.GetFiles("../Archivos/", "*pu.txt");


            if (Publicospdf.Length == 0 && Publicosjpg.Length == 0 && Publicosdoc.Length == 0 && Publicostxt.Length == 0)
            {
                ListaTodosArchivos.Items.Add("No hay archivos subidos en el sistema");
            }

            else
            {

                foreach (string ArchivosPublicospdf in Publicospdf)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPublicospdf.Split(Sep);

                    ListaTodosArchivos.Items.Add(Partes[2] + " Publico");
                }
                foreach (string ArchivosPublicosjpg in Publicosjpg)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPublicosjpg.Split(Sep);

                    ListaTodosArchivos.Items.Add(Partes[2] + " Publico");
                }
                foreach (string ArchivosPublicosdoc in Publicosdoc)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPublicosdoc.Split(Sep);

                    ListaTodosArchivos.Items.Add(Partes[2] + " Publico");
                }
                foreach (string ArchivosPublicostxt in Publicostxt)
                {
                    string Separador = @"/";
                    char Sep = Convert.ToChar(Separador);
                    string[] Partes = ArchivosPublicostxt.Split(Sep);

                    ListaTodosArchivos.Items.Add(Partes[2] + " Publico");
                }

                
            }

            ListaTodosArchivos.Show();
        }
    }
}
