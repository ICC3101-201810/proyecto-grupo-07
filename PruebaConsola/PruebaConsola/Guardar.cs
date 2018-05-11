using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace PruebaConsola
{
    public class Guardar
    {
        public Guardar() { }

        public void Curso(List<Curso> cursos)
        {
            try
            {
                using (Stream stream = File.Open("cursos.bin", FileMode.Create))
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
                using (Stream stream = File.Open("apuntes.bin", FileMode.Create))
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
                using (Stream stream = File.Open("cuentas.bin", FileMode.Create))
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
