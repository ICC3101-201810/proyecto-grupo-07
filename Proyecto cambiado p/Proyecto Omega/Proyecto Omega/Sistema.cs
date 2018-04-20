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
        List<Cuenta> listaCuentas = new List<Cuenta>() { };
        List<Apunte> listaApuntes = new List<Apunte>() { };
        List<Curso> listaCursos = new List<Curso>() { new Curso("nombre", "facultad", "carrera", new List<string>() { })};
        Cuenta cuentaLog = new Admin(-1, "Sistema", "", "Sistema", "", "", "");
        Menu menu = new Menu();
        int auxParse;

        public Sistema() { }

        public bool VerificarContrasena(int miID, string miClaveAcceso)
        {
            foreach (Cuenta revisionCuentas in listaCuentas)
            {
                if (revisionCuentas.ID==miID && 
                    revisionCuentas.claveAcceso==miClaveAcceso)
                {
                    return true;
                }
            }
            return false;
        }

        //Opcion de una Cuenta

        public void subirApunte()
        {
            Console.Write("\nIngrese el Titulo del Apunte: ");
            string miTitulo = Console.ReadLine().Replace(" ", "");
            string auxID;
            do
            {
                Console.Write("Ingrese el ID curso asociado: ");
                auxID = Console.ReadLine().Replace(" ", "");
                if (!Int32.TryParse(auxID, out auxParse))
                {
                    Console.WriteLine("ID invalido");
                }
            } while (!Int32.TryParse(auxID, out auxParse));
            int miIDcurso = Int32.Parse(auxID);
            Console.Write("\nIngrese los topicos separados por ',': ");
            List<string> miTopicos = Console.ReadLine().Replace(" ", "").Split(',').ToList();
            Console.Write("\nIngrese el nombre de la Carrera asociada: ");
            string miCarrera = Console.ReadLine().Replace(" ", "");
            Console.Write("\nEscriba su apunte: ");
            string miInfo = Console.ReadLine();

            List<Curso> miCurso = cuentaLog.BuscarCurso(miIDcurso, listaCursos);

            if (miCurso.Count == 1)
            {
                if (cuentaLog.SubirApunte(new object[] { miTitulo, miCurso[0], miTopicos,
                                          miCarrera, miInfo}, listaApuntes))
                {
                    Console.WriteLine("Apunte subido con exito");
                }
                else
                {
                    Console.WriteLine("No se pudo subir el Apunte, revisa que hayas realizado " +
                                      "el curso");
                }
            }
            else
            {
                Console.WriteLine("No se pudo encontrar un curso con ID {0}", miIDcurso);
            }
        }

        public void mostrarApunteID()
        {
            string auxID;
            do
            {
                Console.Write("\nIngrese el ID del apunte: ");
                auxID = Console.ReadLine();
                if (!Int32.TryParse(auxID, out auxParse))
                {
                    Console.WriteLine("ID invalido");
                }
            } while (!Int32.TryParse(auxID, out auxParse));
            int miID = Int32.Parse(auxID);
            List<Apunte> miApunte = cuentaLog.BuscarApunte(new object[] { miID, "", "" },
                                                           listaApuntes);
            if (miApunte.Count == 1)
            {
                miApunte[0].ImprimirInfo(cuentaLog);
            }
            else
            {
                Console.WriteLine("No se encontro un Apunte con el ID {0}", miID);
            }
        }

        public void mostrarApunteTodos()
        {
            int auxContador = 0;
            foreach (Apunte i in listaApuntes)
            {
                i.ImprimirInfo(cuentaLog);
                auxContador++;
            }
            if (auxContador == 0)
            {
                Console.WriteLine("No hay apuntes en el sistema");
            }
        }

        public void cambiarApunte()
        {
            string auxID;
            do
            {
                Console.Write("Ingrese el ID del apunte: ");
                auxID = Console.ReadLine().Replace(" ", "");
                if (!Int32.TryParse(auxID, out auxParse))
                {
                    Console.WriteLine("ID invalido");
                }
            } while (!Int32.TryParse(auxID, out auxParse));
            int miID = Int32.Parse(auxID);
            if (cuentaLog.BuscarApunte(new object[] { miID, "", "" }, listaApuntes).Count == 1)
            {
                Console.Write("\nSi no quiere cambiar alguno de los datos solo presione enter");
                Console.Write("\nIngrese el Titulo: ");
                string miTitulo = Console.ReadLine().Replace(" ", "");
                Console.Write("\nIngrese los topico a agregar separados por ',': ");
                List<string> miTopicosMas = Console.ReadLine().Replace(" ", "").Split(',').ToList();
                Console.Write("\nIngrese los topicos a eliminar separados por ',': ");
                List<string> miTopicosMenos = Console.ReadLine().Replace(" ", "").Split(',').ToList();
                Console.Write("\nIngrese la Carrera: ");
                string miCarrera = Console.ReadLine().Replace(" ", "");
                Console.Write("\nIngrese el Contenido: ");
                string miContenido = Console.ReadLine().Replace(" ", "");

                if (cuentaLog.ActualizarApunte(miID, new object[] { miTitulo, miTopicosMas,
                                               miTopicosMenos, miCarrera, miContenido}, listaApuntes))
                {
                    Console.WriteLine("\nApunte actualizado con exito\n");
                }
                else
                {
                    Console.WriteLine("No se pudo actualizar el Apunte\n");
                }
            }
            else
            {
                Console.WriteLine("\nNo se encontro un apunte con el ID {0} entre tus apuntes\n", 
                                  miID);
            }
        }

        //Opcion de Admin

        public void crearCuenta()
        {
            string auxID;
            do
            {
                Console.Write("Ingrese su Rut, sin puntos ni guion: ");
                auxID = Console.ReadLine();
                if (!Int32.TryParse(auxID, out auxParse))
                {
                    Console.WriteLine("Rut invalido");
                }
            } while (!Int32.TryParse(auxID, out auxParse));
            int miID = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese su Nombre: ");string miNombre = Console.ReadLine();
            Console.Write("Ingrese su Apellido: ");string miApellido = Console.ReadLine();
            Console.Write("Ingrese su Nombre de Usuario: ");string miNombreUsuario = Console.ReadLine();
            Console.Write("Ingrese su Clave: ");string miClaveAcceso = Console.ReadLine();
            Console.Write("Ingrese su Mail: ");string miEmail = Console.ReadLine();
            Console.Write("Ingrese su Carrera: ");string miCarrera = Console.ReadLine();

            if (((Admin)cuentaLog).CrearCuenta(new object[] {miID, miNombre, miApellido,
                                           miNombreUsuario, miClaveAcceso, miEmail,
                                           miCarrera }, listaCuentas))
            {
                Console.WriteLine("Cuenta {0} creada con exito!", miNombreUsuario);
            }
            else
            {
                Console.WriteLine("No se pudo crear la cuenta");
            }
            
        }

        public void eliminarCuenta()
        {
            Console.Write("\nIngrese el RUT de la cuenta a eliminar");
            int miID = Int32.Parse(Console.ReadLine());
            if(((Admin)cuentaLog).BorrarCuenta(miID, listaCuentas, listaApuntes))
            {
                Console.WriteLine("La cuenta de {0} ha sido eliminada satisfactoriamente", miID);
            }
            else
            {
                Console.WriteLine("La cuenta no se pudo crear, ");
            }
            
        }

        public void crearCurso() { }
    }
}
