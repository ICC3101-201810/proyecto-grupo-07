using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Notes
{
    class Sistema
    {
        StreamWriter TxtCuentas { get; set; }

        public bool VerificarCuenta(int Rut, string Nombre, string Apellido,string Contrasena, string Email, string Carrera)
        {
            Cuenta NuevaCuenta = new Cuenta(Rut,Nombre,Apellido,Contrasena,Email,Carrera);

            TxtCuentas = File.CreateText("Cuentas.txt");

            string ContrasenaCifrada = CifrarContrasena(Contrasena);
            
            TxtCuentas.WriteLine(Rut.ToString()+"#*"+Nombre+"#*"+Apellido+"#*"+ContrasenaCifrada+"#*"+Email+"#*"+Carrera);
            TxtCuentas.Close();
            return true;
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
