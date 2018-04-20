using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Cuenta
    {
        public int id;
        public string nombre;
        public string apellido;
        public string nombreUsuario;
        public string claveAcceso;
        public string email;
        public List<Apunte> apuntesSubidos = new List<Apunte>() { };
        public int valoracionCuenta = 0;
        public List<Curso> cursosRealizados = new List<Curso>() { };
        public List<Cuenta> amigos = new List<Cuenta>() { };
        public List<Cuenta> cuentaFavoritos = new List<Cuenta>() { };
        public string carrera;

        public Cuenta(int miRut, string miNombre,string miApellido,string miNombreUsuario, 
                      string miClaveAcceso,string miEmail,string miCarrera)
        {
            id = miRut;
            nombre = miNombre;
            apellido = miApellido;
            nombreUsuario = miNombreUsuario;
            claveAcceso = miClaveAcceso;
            email = miEmail;
            carrera = miCarrera;

        }

        public List<String> TituloCuenta()
        {
            List<string> titulos = new List<string>() { };
            for (int i = 0; i < this.apuntesSubidos.Count; i++)
            {
                titulos.Add(this.apuntesSubidos[i].titulo);
            }
            return titulos;
        }

        public Apunte SubirApunte(Object[] miDatos)
        {
            return new Apunte(this, (string)miDatos[0], (string)miDatos[1], (List<string>)miDatos[2],
                             (string)miDatos[3], (string)miDatos[4]);
        }
    }
}
