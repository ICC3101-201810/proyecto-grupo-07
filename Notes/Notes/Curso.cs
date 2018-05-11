using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Curso
    {
        private static int Contador_ID = 0;
        //ID el sistema crea uno unico o se ingresa al crear el curso?
        private int ID { get; set; }
        private string NombreCurso { get; set; }
        private string Carrera { get; set; }
        private string Facultad { get; set; }
        private int DificultadValorada { get; set; } //Vamos a dejar una lista de valoraciones? Si no, no se como calcular el valor cada vez que la valoran, puede ser un diccionario con el rut que la valoro y el valor
        private List<int> Apuntes { get; set; } // Referencia al ID de los apuntes?

        public Curso(string miNombreCurso, string miCarrera, string miFacultad, int miDificultadValorada,
                     List<int> miApuntes)
        { //Constructor
            NombreCurso = miNombreCurso;
            Carrera = miCarrera;
            Facultad = miFacultad;
            DificultadValorada = miDificultadValorada;
            Apuntes = miApuntes;
            ID = Contador_ID;
            Contador_ID++;
        } //Constructor

        public int getID() { return ID; }
        public string getNombre() { return NombreCurso; }
        public string getCarrera() { return Carrera; }
        public string getFacultad() { return Facultad; }

        public bool AgregarApunte(int miIDApunte) 
        { //AgregarApunte
            if (!Apuntes.Contains(miIDApunte)) 
            {
                Apuntes.Add(miIDApunte); 
                return true;
            }
            return false;
        } //AgregarApunte
        public bool BorrarApunte(int miIDApunte)
        { //BorrarApunte
            if (Apuntes.Contains(miIDApunte))
            {
                Apuntes.Remove(miIDApunte);
                return true;
            }
            return false;
        } //BorrarApunte
        //public bool Valorar(int valor)
        //{                                 //Si volvemos la valoracion una lista
        //    valoraciones.Add(valor)
        //}
        public string Info()
        {
            string datosSinApuntes = string.Format("\nNombre: \n" +
                "Carrera: \n" +
                "Facultad: \n" +
                "Dificultad: \n");
            if (Apuntes.Count() > 0)
            {
                Console.Write("ID Apuntes: ");
                foreach (int apunte in Apuntes)
                {    //Se agregar los apuntes
                    datosSinApuntes += string.Format(" {0} \n", apunte);
                }
            }
            return datosSinApuntes;
        }
    }
}
