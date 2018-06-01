using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Notes
{
    public class Guardar
    {
        public Guardar() { }

        public void Curso(List<Curso> cursos)
        {
            try
            {
                string auxdirectorio = Directory.GetCurrentDirectory();
                string directorio = auxdirectorio.Substring(0, auxdirectorio.Count() - 9);
                string finalDirectorio;

                foreach (Curso curso in cursos)
                {
                    finalDirectorio = string.Format("\\Datos\\Cursos\\{0}.bin", curso.getID());
                    using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, curso);
                    }
                }
                
            }
            catch (IOException)
            {
            }
        }

        public void Apunte(List<Apunte> apuntes)
        {
            try
            {
                string auxdirectorio = Directory.GetCurrentDirectory();
                string directorio = auxdirectorio.Substring(0, auxdirectorio.Count() - 9);
                string finalDirectorio;

                foreach (Apunte apunte in apuntes)
                {
                    finalDirectorio = string.Format("\\Datos\\Apuntes\\{0}.bin", apunte.getID());
                    using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, apunte);
                    }
                }

            }
            catch (IOException)
            {
            }
        }
        public void Cuenta(List<Cuenta> cuentas)
        {
            try
            {
                string auxdirectorio = Directory.GetCurrentDirectory();
                string directorio = auxdirectorio.Substring(0, auxdirectorio.Count() - 9);
                string finalDirectorio;

                foreach (Cuenta cuenta in cuentas)
                {
                    finalDirectorio = string.Format("\\Datos\\Cuentas\\{0}.bin", cuenta.getNombre());
                    using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, cuenta);
                    }
                }

            }
            catch (IOException)
            {
            }
        }
    }
}
