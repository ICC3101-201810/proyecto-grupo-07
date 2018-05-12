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
<<<<<<< HEAD
        public static File TxtCuentas; 
        
=======
        public Buscar Buscar = new Buscar();
        public Ingresar Ingresar = new Ingresar();
        public Cargar Cargar = new Cargar();
        public Guardar Guardar = new Guardar();

        StreamWriter TxtCuentas { get; set; }
>>>>>>> 2e8662919fa0a00f8f10cf2cf75ee88cc5c1da63

        public bool CrearCuenta(int Rut, string Nombre, string Apellido, string Contrasena, string Email, string Carrera)
        {
            TxtCuentas = new FileStream("Cuentas.txt", FileMode.Create , FileAccess.Write);
            Cuenta NuevaCuenta = new Cuenta(Rut, Nombre, Apellido, Contrasena, Email, Carrera);
            string ContrasenaCifrada = CifrarContrasena(Contrasena);

            byte[] Cuenta = Encoding.ASCII.GetBytes(Rut + "#*" + Nombre + "#*" + Apellido + "#*" + Contrasena + "#*" + Email + "#*" + Carrera);
            TxtCuentas.Write(Cuenta,0,Cuenta.Length);

            return true;
        }

        public bool VerificarCuenta(int Rut)
        {



            /*using (StreamReader LeerCuentas = new StreamReader("Cuentas.txt"))
            {
                while (!LeerCuentas.EndOfStream)
                {
                    string Linea = LeerCuentas.ReadLine();
                    string Separador = "#*";
                    char Sep = Convert.ToChar(Separador);
                    string[] Atributos = Linea.Split(Sep);

                    foreach (string Atributo in Atributos)
                    {
                        if (Atributo == Rut.ToString())
                        {
                            return false;
                        }                       
                    }
                    
                }
                
            }*/
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
