using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    public class PruebaEnConsola
    {
        public List<Curso> Cursos = new List<Curso>() { };
        public List<Apunte> Apuntes = new List<Apunte>() { };
        public List<Cuenta> Cuentas = new List<Cuenta>() { };

        public Sistema Sistema = new Sistema();

        public PruebaEnConsola() { }

        public void Probar()
        {
            while (true)
            {
                Console.Write("1-CrearCuenta\n" +
                              "2-BuscarCuentas\n" +
                              "3-BorrarCuenta\n" +
                              "4-CrearCurso\n" +
                              "5-BuscarCurso\n" +
                              "6-BorrarCurso\n" +
                              "7-CrearApunte\n" +
                              "8-BuscarApunte\n" +
                              "9-BorrarApunte\n");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        CrearCuenta();                        
                        break;
                    case "2":
                        BuscarCuenta();
                        break;
                    case "3":
                        BorrarCuenta();
                        break;
                    case "4":
                        CrearCurso();
                        break;
                    case "5":
                        BuscarCurso();
                        break;
                    case "6":
                        BorrarCurso();
                        break;
                    case "7":
                        CrearApunte();
                        break;
                    case "8":
                        BuscarApunte();
                        break;
                    case "9":
                        BorrarApunte();
                        break;

                }
            }
        }

        public void CrearCuenta()
        {
            Console.WriteLine("Cuenta");
            int[] auxRut;
            string[] auxNombre;
            string[] auxApellido;
            string[] auxContrasena;
            string[] auxEmail;
            string[] auxCarrera;
            do
            {
                Console.Write("Ingrese Rut: ");
                string Rut_ = Console.ReadLine();
                auxRut = Sistema.Ingresar.Rut(Rut_);
                if (auxRut.Count() == 0)
                {
                    Console.WriteLine("Invalido");
                }
            } while (auxRut.Count() == 0);
            do
            {
                Console.Write("Ingrese Nombre: ");
                auxNombre = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxNombre.Count() == 0);
            do
            {
                Console.Write("Ingrese Apellido: ");
                auxApellido = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxApellido.Count() == 0);
            do
            {
                Console.Write("Ingrese Contrasena: ");
                auxContrasena = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxContrasena.Count() == 0);
            do
            {
                Console.Write("Ingrese Email: ");
                auxEmail = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxEmail.Count() == 0);
            do
            {
                Console.Write("Ingrese Carrera: ");
                auxCarrera = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxCarrera.Count() == 0);
            if (Sistema.Buscar.Cuenta("RUT", auxRut[0].ToString(), Cuentas).Count() == 0)
            {
                Cuentas.Add(new Cuenta(auxRut[0], auxNombre[0], auxApellido[0], auxContrasena[0],
                                       auxEmail[0], auxCarrera[0]));
                Console.WriteLine(Cuentas[Cuentas.Count() - 1].Info());
            }
            else
            {
                Console.WriteLine("No se pudo crear");
            }
        }

        public void BuscarCuenta()
        {
            string[] auxParametro;
            do
            {
                Console.Write("Ingrese Parametro: ");
                auxParametro = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxParametro.Count() == 0);
            int[] auxValorRut;
            string[] auxValor;
            if (auxParametro[0] == "RUT")
            {
                do
                {
                    Console.Write("Ingrese Rut: ");
                    string Rut_ = Console.ReadLine();
                    auxValorRut = Sistema.Ingresar.Rut(Rut_);
                    if (auxValorRut.Count() == 0)
                    {
                        Console.WriteLine("Invalido");
                    }
                } while (auxValorRut.Count() == 0);
                auxValor = new string[] { auxValorRut[0].ToString() };
            }
            else
            {
                do
                {
                    Console.Write("Ingrese Valor: ");
                    auxValor = Sistema.Ingresar.String(Console.ReadLine());
                } while (auxValor.Count() == 0);
            }
            foreach (Cuenta cuenta in Sistema.Buscar.Cuenta(auxParametro[0], auxValor[0], Cuentas))
            {
                Console.Write(cuenta.Info());
            }
        }

        public void BorrarCuenta()
        {
            int[] auxRut;
            do
            {
                Console.Write("Ingrese Rut: ");
                string Rut_ = Console.ReadLine();
                auxRut = Sistema.Ingresar.Rut(Rut_);
                if (auxRut.Count() == 0)
                {
                    Console.WriteLine("Invalido");
                }
            } while (auxRut.Count() == 0);

            if(Sistema.Buscar.Cuenta("RUT", auxRut[0].ToString(), Cuentas).Count() != 0)
            {
                Cuentas.Remove(Cuentas.Single(x => x.getRut() == auxRut[0]));
                Console.WriteLine("Cuenta borrada");
            }
            else
            {
                Console.WriteLine("No se pudo borrar");
            }

        }

        public void CrearApunte()
        {
            int[] auxAutor;
            int[] auxCurso;
            string[] auxTitulo;
            string[] auxCarrera;
            string[] auxTopicos;
            //Ingresar Datos
            #region
            do
            {
                Console.Write("Ingrese ID Autor: ");
                auxAutor = Sistema.Ingresar.Int(Console.ReadLine());
            } while (auxAutor.Count() == 0);
            do
            {
                Console.Write("Ingrese ID Curso: ");
                auxCurso = Sistema.Ingresar.Int(Console.ReadLine());
            } while (auxCurso.Count() == 0);
            do
            {
                Console.Write("Ingrese Titulo: ");
                auxTitulo = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxTitulo.Count() == 0);
            do
            {
                Console.Write("Ingrese Carrera: ");
                auxCarrera = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxCarrera.Count() == 0);
            do
            {
                Console.Write("Ingrese Topicos separados por ',': ");
                auxTopicos = Console.ReadLine().Replace(" ", "").Split(',').ToArray();
            } while (auxTopicos.Count() == 0);
            #endregion
            if ((Sistema.Buscar.Cuenta("RUT", auxAutor[0].ToString(), Cuentas).Count == 1) &&
                (Sistema.Buscar.Curso("ID", auxCurso[0].ToString(), Cursos).Count() == 1))
            {
                Apuntes.Add(new Apunte(auxAutor[0], auxCurso[0], auxTitulo[0], auxCarrera[0], 
                                       auxTopicos.ToList()));
            }
            else
            {
                Console.WriteLine("No se pudo crear");
            }
        }

        public void BuscarApunte()
        {
            string[] auxParametro;
            do
            {
                Console.Write("Ingrese Parametro: ");
                auxParametro = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxParametro.Count() == 0);
            string[] auxValor;
            do
            {
                Console.Write("Ingrese Valor: ");
                auxValor = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxValor.Count() == 0);
            //Se consigue una lista con los parametros pedidos
            foreach(Apunte apunte in Sistema.Buscar.Apunte(auxParametro[0], auxValor[0], Apuntes))
            {
                apunte.Info();
            }

        }

        public void BorrarApunte()
        {
            int[] auxID;
            do
            {
                Console.Write("Ingrese ID Apunte: ");
                auxID = Sistema.Ingresar.Int(Console.ReadLine());
            } while (auxID.Count() == 0);

            if (Sistema.Buscar.Apunte("ID", auxID[0].ToString(), Apuntes).Count() != 0)
            {
                Apuntes.Remove(Apuntes.Single(x => x.getID() == auxID[0]));
                Console.WriteLine("Apunte Borrado");
            }
            else
            {
                Console.WriteLine("No se pudo borrar el apunte");
            }
        }

        public void CrearCurso()
        {
            string[] auxNombre;
            string[] auxCarrera;
            string[] auxFacultad;
            do
            {
                Console.Write("Ingrese Nombre: ");
                auxNombre = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxNombre.Count() == 0);
            do
            {
                Console.Write("Ingrese Carrera: ");
                auxCarrera = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxCarrera.Count() == 0);
            do
            {
                Console.Write("Ingrese Facultad: ");
                auxFacultad = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxFacultad.Count() == 0);

            Cursos.Add(new Curso(auxNombre[0], auxCarrera[0], auxFacultad[0]));
            Console.WriteLine("Curso agregado");

        }

        public void BuscarCurso()
        {
            string[] auxParametro;
            do
            {
                Console.Write("Ingrese Parametro: ");
                auxParametro = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxParametro.Count() == 0);
            string[] auxValor;
            do
            {
                Console.Write("Ingrese Valor: ");
                auxValor = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxValor.Count() == 0);
            //Se consigue una lista con los parametros pedidos
            foreach (Curso curso in Sistema.Buscar.Curso(auxParametro[0], auxValor[0], Cursos))
            {
                curso.Info();
            }
        }

        public void BorrarCurso()
        {
            int[] auxID;
            do
            {
                Console.Write("Ingrese ID Curso: ");
                auxID = Sistema.Ingresar.Int(Console.ReadLine());
            } while (auxID.Count() == 0);

            if (Sistema.Buscar.Curso("ID", auxID[0].ToString(), Cursos).Count() != 0)
            {
                Cursos.Remove(Cursos.Single(x => x.getID() == auxID[0]));
                Console.WriteLine("Curso Borrado");
            }
            else
            {
                Console.WriteLine("No se pudo borrar el curso");
            }
        }
    }
}
