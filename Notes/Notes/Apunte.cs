using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class Apunte
    {
        private static int Contador_ID = 0; 

        private int ID { get; set;  } // ID, el sistema crea uno unico o se ingresa al crear el apunte?
        private int Autor { get; set; } //El ID del autor
        private int Curso { get; set; } //ID de los cursos
        private string Titulo { get; set; }        
        private string Carrera { get; set; }
        private List<string> Topicos { get; set; }
        private int Valoracion { get; set; } //Vamos a dejar una lista de valoraciones? Si no, no se como calcular el valor cada vez que la valoran, puede ser un diccionario con el rut que la valoro y el valor
        private bool Publico { get; set; }
        //private List<int> UsuariosCompartido { get; set; } /Yo sacaria esto por ahora

        public int getID() { return ID; }
        public int getAutor() { return Autor; }
        public int getCurso() { return Curso; }
        public string getTitulo() { return Titulo; }
        public string getCarrera() { return Carrera; }

        public Apunte(int miAutor, int miCurso, string miTitulo, string miCarrera, List<string> miTopicos)
        { //Constructor
            Autor = miAutor;
            Curso = miCurso;
            Titulo = miTitulo;
            Carrera = miCarrera;
            Topicos = miTopicos;
            ID = Contador_ID;
            Contador_ID++;
        } //Constructor

        public bool Publicar(bool miPublicado)
        { //Publicar
            if (Publico != miPublicado)
            {
                Publico = miPublicado;
                return true;
            }
            return false;
        } //Publicar

        public bool AgregarTopico(string miTopico)
        { //Agregar topico
            if (!Topicos.Contains(miTopico))
            {
                Topicos.Add(miTopico);
                return true;
            }
            return false;
        } //Agregar topico

        public bool BorrarTopico(string miTopico)
        { //Borrar topico
            if (Topicos.Contains(miTopico))
            {
                Topicos.Remove(miTopico);
                return true;
            }
            return false;
        } //Borrar topico

        public string Info()
        { //Info
            string datosApunte = string.Format("\nID   :\n" +
                                                   "Autor  :\n" +
                                                   "Curso  :\n" +
                                                   "Titulo :\n" +
                                                   "Carrera:\n", ID, Autor, Curso, Titulo, Carrera);
            //No se como mostrar el contenido
            return datosApunte;
        } //Info
    }
}
