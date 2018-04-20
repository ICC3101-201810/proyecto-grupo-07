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
        public Curso curso;
        public List<string> topico;
        public string carrera;
        public List<int> valoracion = new List<int>() { };
        public string contenido;
        public bool publico = false;
        //public List<Cuenta> usuariosCompartido = new List<Cuenta>() { };
        public List<Reporte> reportes = new List<Reporte>() { };

        public Apunte(Cuenta Autor, string Titulo, Curso Curso, List<string> Topico, string Carrera, 
                      string Contenido)
        {
            autor = Autor;
            titulo = Titulo;
            curso = Curso;
            topico = Topico;
            carrera = Carrera;
            contenido = Contenido;
            ID = System.Threading.Interlocked.Increment(ref m_Counter);
        }

        public void ImprimirInfo(Cuenta miAutor)
        {
            if (publico || autor == miAutor)
            {
                Console.Write("\nID: {0}\n" +
                            "Autor: {1}\n" +
                            "Titulo: {2}\n" +
                            "Curso: {3}\n" +
                            "Topicos: ",ID, autor.ID, titulo, curso);
                Console.Write("[{0}]", string.Join(", ", topico));
                Console.Write("\nCarrera: {0}\n" +
                              "Valoracion: {1}\n" +
                              "Contenido: {2}\n",carrera, valoracion, contenido);
            }
        }
    }
}
