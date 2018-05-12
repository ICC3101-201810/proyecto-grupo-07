using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class Datos
    {
        public Sistema Sistema = new Sistema();

        public List<Curso> Cursos = new List<Curso>() { };
        public List<Apunte> Apuntes = new List<Apunte>() { };
        public List<Cuenta> Cuentas = new List<Cuenta>() { };
    }
}
