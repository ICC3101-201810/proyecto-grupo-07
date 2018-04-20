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
        List<Cuenta> listaCuentas = new List<Cuenta>();
        List<Apunte> listaApuntes = new List<Apunte>();
        //List<Carrera> listaCarreras;

        public int verificarContrasena(string miNombreUsuario, string miClaveAcceso)
        {
            Console.WriteLine("llamo al metodo");
            Console.WriteLine(listaCuentas.Count);
            Console.WriteLine("asd");
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                Cuenta revisionCuentas = listaCuentas[i];
                Console.WriteLine(revisionCuentas.tipo);
                if (revisionCuentas.nombreUsuario == miNombreUsuario && revisionCuentas.claveAcceso == miClaveAcceso)
                {
                    if (revisionCuentas.tipo=="Estudiante")
                    {
                        return 11;
                    }
                    if (revisionCuentas.tipo=="Profesor")
                    {
                        return 12;
                    }
                    if (revisionCuentas.tipo=="Administrador")
                    {
                        return 13;
                    }
                }
            }

            return 10 ;
        }


        public void crearCuenta()
        {
            Console.Write("Ingrese su Rut(sin puntos ni guion): ");int miId = Int32.Parse(Console.ReadLine()); 
            Console.Write("Ingrese su nombre: ");string miNombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");string miApellido = Console.ReadLine();
            Console.Write("Ingrese su nombre de Usuario: ");string miNombreUsuario = Console.ReadLine();
            Console.Write("Ingrese su contrasena: ");string miClaveAcceso = Console.ReadLine();
            Console.Write("Ingrese su email: ");string miEmail = Console.ReadLine();
            Console.Write("Seleccione la carrera que cursa: ");int miCarrera = Int32.Parse(Console.ReadLine());

            Cuenta nuevaCuenta = new Cuenta(miId, miNombre, miApellido, miNombreUsuario, miClaveAcceso, miEmail,"Estudiante", miCarrera);
            listaCuentas.Add(nuevaCuenta);
            Console.Clear();
            Console.WriteLine("Tu Cuenta a sido creada exitosamente");

        }

        public void eliminarCuenta(int miId)
        {
            foreach (Cuenta revisionCuentas in listaCuentas)
            {
                if (revisionCuentas.RUT==miId)
                {
                    Console.WriteLine("La cuenta de {0} {1} ha sido eliminada satisfactoriamente", revisionCuentas.nombre, revisionCuentas.apellido);
                    listaCuentas.Remove(revisionCuentas);
                    
                }
                
            }
            
        }

    }
}
