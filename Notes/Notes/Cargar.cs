using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Notes
{
    public class Cargar
    {
        public Cargar() { }

        public List<Curso> Curso()
        {
            try
            {
                string auxdirectorio = Directory.GetCurrentDirectory();
                string directorio = auxdirectorio.Substring(0, auxdirectorio.Count() - 9);
                string finalDirectorio = "\\Datos\\Cursos";
                List<Curso> cursosCargados = new List<Curso>() { };

                string[] cursos = Directory.GetFiles(finalDirectorio, "*.bin");

                foreach (string IDCurso in cursos)
                {
                    using (Stream stream = File.Open(directorio + finalDirectorio + IDCurso, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        cursosCargados.Add((Curso)bin.Deserialize(stream));
                    }

                }
                return cursosCargados;
                
            }
            catch (IOException)
            {
                return new List<Curso>() { };
            }
        }
        public List<Apunte> Apunte()
        {
            try
            {
                string auxdirectorio = Directory.GetCurrentDirectory();
                string directorio = auxdirectorio.Substring(0, auxdirectorio.Count() - 9);
                string finalDirectorio = "\\Datos\\Apuntes";
                List<Apunte> apuntesCargados = new List<Apunte>() { };

                string[] apuntes = Directory.GetFiles(finalDirectorio, "*.bin");

                foreach (string IDApunte in apuntes)
                {
                    using (Stream stream = File.Open(directorio + finalDirectorio + IDApunte, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        apuntesCargados.Add((Apunte)bin.Deserialize(stream));
                    }

                }
                return apuntesCargados;

            }
            catch (IOException)
            {
                return new List<Apunte>() { };
            }
        }
        public List<Cuenta> Cuenta()
        {
            try
            {
                string auxdirectorio = Directory.GetCurrentDirectory();
                string directorio = auxdirectorio.Substring(0, auxdirectorio.Count() - 9);
                string finalDirectorio = "\\Datos\\Cuentas";
                List<Cuenta> cuentasCargadas = new List<Cuenta>() { };

                string[] cuentas = Directory.GetFiles(finalDirectorio, "*.bin");

                foreach (string RUTCuenta in cuentas)
                {
                    using (Stream stream = File.Open(directorio + finalDirectorio + RUTCuenta, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        cuentasCargadas.Add((Cuenta)bin.Deserialize(stream));
                    }

                }
                return cuentasCargadas;

            }
            catch (IOException)
            {
                return new List<Cuenta>() { };
            }
        }
    }
}
