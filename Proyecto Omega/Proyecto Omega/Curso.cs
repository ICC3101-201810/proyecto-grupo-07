using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Curso
    {
        public int ID;
        public string nombreCurso;
        public string facultad;
        public List<Apunte> apuntes = new List<Apunte>() { };
        public string carrera;
        public List<string> topico;
        public int dificultadValorada = 0;

        public Curso(string NombreCurso, string Facultad, string Carrera, List<string> Topico)
        {
            nombreCurso = NombreCurso;
            facultad = Facultad;
            carrera = Carrera;
            topico = Topico;
        }
    }
}
