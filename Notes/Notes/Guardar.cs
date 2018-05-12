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
                string finalDirectorio = "\\Datos\\cursos.bin";
                Console.WriteLine(directorio + finalDirectorio);
                using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, cursos);
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
                string finalDirectorio = "\\Datos\\apuntes.bin";
                using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, apuntes);
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
                string finalDirectorio = "\\Datos\\cuentas.bin";
                using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, cuentas);
                }
            }
            catch (IOException)
            {
            }
        }
    }
}
