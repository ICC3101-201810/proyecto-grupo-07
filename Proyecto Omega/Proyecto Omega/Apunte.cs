using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Apunte
    {
        private static int m_Counter = 0;

        public int ID { get; set; }

        public Cuenta autor;
        public string titulo;
        public string curso;
        public List<string> topico;
        public string carrera;
        public int valoracion = 0;
        public string contenido;
        public bool publico = false;
        public List<Cuenta> usuariosCompartido = new List<Cuenta>() { };

        public Apunte(Cuenta Autor, string Titulo, string Curso, List<string> Topico, string Carrera, 
                      string Contenido)
        {
            autor = Autor;
            titulo = Titulo;
            curso = Curso;
            topico = Topico;
            carrera = Carrera;
            contenido = Contenido;
            this.ID = System.Threading.Interlocked.Increment(ref m_Counter);
        }
    }
}
