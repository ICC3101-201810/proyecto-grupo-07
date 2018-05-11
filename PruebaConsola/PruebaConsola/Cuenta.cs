using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    public class Cuenta
    {
        private int Rut { get; set; } //Remplacemos la K con 0, es muuucho mas simple
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Contrasena { get; set; }
        private string Email { get; set; }
        private string Carrera { get; set; }
        private List<int> ApuntesSubidos { get; set; }
        private List<int> ValoracionCuenta { get; set; }
        private List<int> CursosRealizados { get; set; }
        private List<int> Amigos { get; set; }
        private List<int> Favoritos { get; set; }
        private List<int> Reportes { get; set; }

        public Cuenta(int miRut, string miNombre, string miApellido,
                        string miContrasena, string miEmail, string miCarrera)
        {
            Rut = miRut;
            Nombre = miNombre;
            Apellido = miApellido;
            Contrasena = miContrasena;
            Email = miEmail;
            Carrera = miCarrera;
        }
        public int getRut() { return Rut; }
        public string getNombre() { return Nombre; }
        public string getCarrera() { return Carrera; }

        public string Info()
        {
            return string.Format("\nRut     : {0}\n" +
                                   "Nombre  : {1}\n" +
                                   "Apellido: {2}\n" +
                                   "Email   : {3}\n" +
                                   "Carrera : {4}\n", Rut, Nombre, Apellido, Email, Carrera);
        }

        //public Apunte SubirApunte()

        //public
    }
}
