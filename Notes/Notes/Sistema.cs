using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Notes
{
    public class Sistema
    {

        public Buscar Buscar = new Buscar();
        public Ingresar Ingresar = new Ingresar();
        public Cargar Cargar = new Cargar();
        public Guardar Guardar = new Guardar();

        StreamWriter TxtCuentas { get; set; }


        public bool VerificarContrasena(string Rut, string Contrasena)
        {
            string[] LineasTexto = File.ReadAllLines(Rut + ".txt");

            string Separador = "_*";
            char Sep = Convert.ToChar(Separador);
            string[] Atributos = LineasTexto[0].Split(Sep);

            string CCifrada = CifrarContrasena(Contrasena);

            if (CCifrada==Atributos[4])
            {
                return true;
            }

            return false;
            
        }

        public string CifrarContrasena(string Contrasena)
        {
            SHA1 Encriptado = new SHA1CryptoServiceProvider();

            byte[] Bytes = (new UnicodeEncoding()).GetBytes(Contrasena);
            byte[] EncriptadoContrasena = Encriptado.ComputeHash(Bytes);

            return Convert.ToBase64String(EncriptadoContrasena);            
        }
    }
}
