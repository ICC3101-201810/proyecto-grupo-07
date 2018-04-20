using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_Omega
{
    class Sistema
    {
        List<Cuenta> listaCuentas;

        public bool verificarContrasena(string miNombreUsuario, string miClaveAcceso)
        {
            foreach (Cuenta revisionCuentas in listaCuentas)
            {
                if (revisionCuentas.nombreUsuario==miNombreUsuario && revisionCuentas.claveAcceso==miClaveAcceso)
                {
                    return true;
                }
            }
            return false;
        }


        public void crearCuenta()
        {
            Console.Write("Ingrese su Rut: ");int miId = Int32.Parse(Console.ReadLine()); 
            Console.Write("Ingrese su Rut: ");string miNombre = Console.ReadLine();
            Console.Write("Ingrese su Rut: ");string miApellido = Console.ReadLine();
            Console.Write("Ingrese su Rut: ");string miNombreUsuario = Console.ReadLine();
            Console.Write("Ingrese su Rut: ");string miClaveAcceso = Console.ReadLine();
            Console.Write("Ingrese su Rut: ");string miEmail = Console.ReadLine();
            Console.Write("Ingrese su Rut: ");string miCarrera = Console.ReadLine();

            Cuenta nuevaCuenta = new Cuenta(miId, miNombre, miApellido, miNombreUsuario, miClaveAcceso, miEmail, miCarrera);
            listaCuentas.Add(nuevaCuenta);
        }

        public void eliminarCuenta(int miId)
        {
            foreach (Cuenta revisionCuentas in listaCuentas)
            {
                if (revisionCuentas.id==miId)
                {
                    Console.WriteLine("La cuenta de {0} {1} ha sido eliminada satisfactoriamente", revisionCuentas.nombre, revisionCuentas.apellido);
                    listaCuentas.Remove(revisionCuentas);
                    
                }
                
            }
            
        }

    }
}
