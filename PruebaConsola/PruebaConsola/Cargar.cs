using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace PruebaConsola
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
                Console.WriteLine(directorio);
                string finalDirectorio = "\\Datos\\cursos.bin";
                using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    return (List<Curso>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Exception Cargar Cursos");
                return new List<Curso>() { };
            }
        }
        public List<Apunte> Apunte()
        {
            try
            {
                string auxdirectorio = Directory.GetCurrentDirectory();
                string directorio = auxdirectorio.Substring(0, auxdirectorio.Count() - 9);
                string finalDirectorio = "\\Datos\\apuntes.bin";
                using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    return (List<Apunte>)bin.Deserialize(stream);
                }
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
                string finalDirectorio = "\\Datos\\cuentas.bin";
                using (Stream stream = File.Open(directorio + finalDirectorio, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    return (List<Cuenta>)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                return new List<Cuenta>() { };
            }
        }
    }
}
