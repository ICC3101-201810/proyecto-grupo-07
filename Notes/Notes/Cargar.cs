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
                using (Stream stream = File.Open("cursos.bin", FileMode.Open))
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
                using (Stream stream = File.Open("apuntes.bin", FileMode.Open))
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
                using (Stream stream = File.Open("cuentas.bin", FileMode.Open))
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
