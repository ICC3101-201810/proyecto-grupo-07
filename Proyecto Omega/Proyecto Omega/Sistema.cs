using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    class Sistema
    {
        List<Cuenta> listaCuentas;

        public void crearCuenta(int miId, string miNombre, string miApellido, string miNombreUsuario, string miClaveAcceso, string miEmail, List<int> miApuntesSubidos, int miValoriacionCuenta, List<int> miCursosRealizados, List<int> miAmigos, List<int> miCuentaFavoritos, string miCarrera)
        {
            Cuenta nuevaCuenta = new Cuenta(miId, miNombre, miApellido, miNombreUsuario, miClaveAcceso, "Estudiante", miEmail, miApuntesSubidos, miValoriacionCuenta, miCursosRealizados, miAmigos, miCuentaFavoritos, miCarrera);
            listaCuentas.Add(nuevaCuenta);
        }

        public void eliminarCuenta(int miId)
        {
            foreach (Cuenta revisionCuentas in listaCuentas)
            {
                int contador = 0;
                if (revisionCuentas.id==miId)
                {
                    Console.WriteLine("La cuenta de {0} {1} ha sido eliminada satisfactoriamente", revisionCuentas.nombre, revisionCuentas.apellido);
                    //cuenta[contador]
                    
                }
                contador = contador + 1;
            }
            
        }

    }
}
