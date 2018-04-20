using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Cuenta
    {
        private int id;
        public string nombre;
        public string apellido;
        string nombreUsuario;
        string claveAcceso;
        string tipo;
        string email;
        List<int> apuntesSubidos;
        int valoracionCuenta;
        List<int> cursosRealizados;
        List<int> amigos;
        List<int> cuentaFavoritos;
        string carrera;

        public Cuenta(int miId, string miNombre,string miApellido,string miNombreUsuario,string miClaveAcceso,string miTipo,string miEmail,List<int> miApuntesSubidos,int miValoriacionCuenta,List<int> miCursosRealizados,List<int> miAmigos,List<int> miCuentaFavoritos,string miCarrera)
        {
            id = miId;
            nombre = miNombre;
            apellido = miApellido;
            nombreUsuario = miNombreUsuario;
            claveAcceso = miClaveAcceso;
            tipo = miTipo;
            email = miEmail;
            apuntesSubidos = miApuntesSubidos;
            valoracionCuenta = miValoriacionCuenta;
            cursosRealizados = miCursosRealizados;
            amigos = miAmigos;
            cuentaFavoritos = miCuentaFavoritos;
            carrera = miCarrera;

        }


    }
}
