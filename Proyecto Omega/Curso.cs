using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Curso
    {
        private static int m_Counter = 0;

        public int ID { get; set; }

        public string nombreCurso;
        public string facultad;
        public List<int> apuntes = new List<int>() { };
        public string carrera;
        public List<string> topico;
        public List<int> dificultadValorada = new List<int>() { }; 

        public Curso(string NombreCurso, string Facultad, string Carrera, List<string> Topico)
        {
            nombreCurso = NombreCurso;
            facultad = Facultad;
            carrera = Carrera;
            topico = Topico;
            ID = System.Threading.Interlocked.Increment(ref m_Counter);
        }

    
        public void CargarDatos(List<int> miApuntes, List<int> miDificultad)
        {
            apuntes = miApuntes;
            dificultadValorada = miDificultad;
        }
    }
}
