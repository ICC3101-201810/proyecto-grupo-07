using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Cuenta
    {
        private static int m_Counter = 0;

        public int ID { get; set; }

        public string nombre;
        public string apellido;
        public string nombreUsuario;
        public string claveAcceso;
        public string email;
        public string RUT;
        public List<Apunte> apuntesSubidos = new List<Apunte>() { };
        public int valoracionCuenta = 0;
        public List<Curso> cursosRealizados = new List<Curso>() { };
        public List<Cuenta> amigos = new List<Cuenta>() { };
        public List<Cuenta> cuentaFavoritos = new List<Cuenta>() { };
        public string carrera;

        public Cuenta(string miNombre,string miApellido,string miNombreUsuario, 
                      string miClaveAcceso,string miEmail,string miCarrera)
        {
            nombre = miNombre;
            apellido = miApellido;
            nombreUsuario = miNombreUsuario;
            claveAcceso = miClaveAcceso;
            email = miEmail;
            carrera = miCarrera;
            this.ID = System.Threading.Interlocked.Increment(ref m_Counter);
        }

    }
}
