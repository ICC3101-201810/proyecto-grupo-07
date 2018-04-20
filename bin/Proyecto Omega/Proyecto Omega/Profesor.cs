using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Profesor : Cuenta
    {
        public List<int> cursosEnsena = new List<int>() { };

        public Profesor(int miRUT, string Nombre, string Apellido, string NombreUsuario, string ClaveAcceso,
                        string Email, string Carrera)
             : base(miRUT, Nombre, Apellido, NombreUsuario, ClaveAcceso, Email, Carrera) { }

        // Lo elimina de la lista del curso, cuenta que lo creo y base de datos
        public bool BorrarApunte(int IDApunte, List<Apunte> TodosApuntes)
        {
            List<Apunte> apunte = BuscarApunte(new Object[] { IDApunte, "", "" }, TodosApuntes);
            if (apunte.Count == 1)
            {
                if (cursosEnsena.Contains(apunte[0].ID))
                {
                    apunte[0].autor.apuntesSubidos.Remove(apunte[0].ID);
                    apunte[0].curso.apuntes.Remove(apunte[0].ID);
                    TodosApuntes.Remove(apunte[0]);
                    return true;
                }
            }
            return false;
        }

        public bool SubirApunte(Object[] miDatos, List<Apunte> TodosApuntes)
        {
            Curso auxCurso = (Curso)miDatos[2];
            if (cursosRealizados.Contains(auxCurso.ID)||cursosEnsena.Contains(auxCurso.ID))
            {
                Apunte miApunte = new Apunte(this, (string)miDatos[0], (Curso)miDatos[1], (List<string>)miDatos[2],
                                 (string)miDatos[3], (string)miDatos[4]);
                apuntesSubidos.Add(miApunte.ID);
                auxCurso.apuntes.Add(miApunte.ID);
                return true;
            }
            return false;
        }

        // Se diferencia por que tambien puede cambiar apuntes no suyos de un curso que ensene
        public bool ActualizarApunte(int IDApunte, string[] miDatos, List<Apunte> todosApuntes)
        {   // Al buscar por ID a lo mas puede haber un resultado
            List<Apunte> miApunte = BuscarApunteTodos(new Object[] { IDApunte, "", "" }, todosApuntes);
            if (miApunte.Count == 1)
            {
                if (cursosRealizados.Contains(miApunte[0].ID))
                {
                    if (miDatos[0] != "")                      // Se ve si hay datos a actualizar, solo
                    {                                          // se puede actualizar un topico a la vez.
                        miApunte[0].titulo = miDatos[0];       // Aqui solo se puede cambiar titulo, 
                                                               // topicos, carrera y contenido
                    }                                          // los otros datos tienen otros metodos.
                    if (miDatos[2] != "")  // Agrega el topico si no lo tiene.
                    {
                        if (!miApunte[0].topico.Contains(miDatos[2]))
                        {
                            miApunte[0].topico.Add(miDatos[2]);
                        }
                    }
                    if (miDatos[3] != "")  // Borra el topico si lo tiene
                    {
                        if (miApunte[0].topico.Contains(miDatos[3]))
                        {
                            miApunte[0].topico.Remove(miDatos[3]);
                        }
                    }
                    if (miDatos[4] != "")
                    {
                        miApunte[0].carrera = miDatos[4];
                    }
                    if (miDatos[5] != "")
                    {
                        miApunte[0].contenido = miDatos[5];
                    }
                    return true;
                }
            }
            return false;
        }
        

    }
}
