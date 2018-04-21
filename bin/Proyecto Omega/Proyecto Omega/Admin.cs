using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Admin : Cuenta
    {
        public Admin(int RUT, string Nombre, string Apellido, string NombreUsuario, string ClaveAcceso,
                     string Email, string Carrera)
             : base(RUT, Nombre, Apellido, NombreUsuario, ClaveAcceso, Email, Carrera) { }

        public bool CrearCuenta(Object[] DatosCuenta, List<Cuenta> TodasCuentas)
        {
            bool checkRUT = true;
            for (int i = 0; i < TodasCuentas.Count; i++)
            {
                if (TodasCuentas[i].ID == (int)DatosCuenta[0] && (int)DatosCuenta[0] != -1) // Se revisa que no haya una cuenta
                {                                               // con ese RUT creado
                    checkRUT = false;
                }
            }
            if (checkRUT)
            {
                TodasCuentas.Add(new Cuenta((int)DatosCuenta[0], (string)DatosCuenta[1],
                                           (string)DatosCuenta[2], (string)DatosCuenta[3],
                                           (string)DatosCuenta[4], (string)DatosCuenta[5],
                                           (string)DatosCuenta[6]));
                return true;
            }
            return false;
        }

        public bool CrearProfesor(Object[] DatosCuenta, List<Cuenta> TodasCuentas)
        {
            bool checkRUT = true;
            for (int i = 0; i < TodasCuentas.Count; i++)
            {
                if (TodasCuentas[i].ID == (int)DatosCuenta[0]) // Se revisa que no haya una cuenta
                {                                               // con ese RUT creado
                    checkRUT = false;
                }
            }
            if (checkRUT)
            {
                TodasCuentas.Add(new Profesor((int)DatosCuenta[0], (string)DatosCuenta[1],
                                           (string)DatosCuenta[2], (string)DatosCuenta[3],
                                           (string)DatosCuenta[4], (string)DatosCuenta[5],
                                           (string)DatosCuenta[6]));
                return true;
            }
            return false;
        }

        public bool CrearAdmin(Object[] DatosCuenta, List<Cuenta> TodasCuentas)
        {
            bool checkRUT = true;
            for (int i = 0; i < TodasCuentas.Count; i++)
            {
                if (TodasCuentas[i].ID == (int)DatosCuenta[0]) // Se revisa que no haya una cuenta
                {                                               // con ese RUT creado
                    checkRUT = false;
                }
            }
            if (checkRUT)
            {
                TodasCuentas.Add(new Admin((int)DatosCuenta[0], (string)DatosCuenta[1],
                                           (string)DatosCuenta[2], (string)DatosCuenta[3],
                                           (string)DatosCuenta[4], (string)DatosCuenta[5],
                                           (string)DatosCuenta[6]));
                return true;
            }
            return false;
        }

        public bool ModificarCuentaOtro(int RUTCuenta, List<string> DatosCuenta,
                                        List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {
                if (DatosCuenta[0] != "")
                {
                    cuenta[0].nombre = DatosCuenta[0];
                }
                if (DatosCuenta[1] != "")
                {
                    cuenta[0].apellido = DatosCuenta[1];
                }
                if (DatosCuenta[2] != "")
                {
                    cuenta[0].nombreUsuario = DatosCuenta[2];
                }
                if (DatosCuenta[3] != "")
                {
                    cuenta[0].claveAcceso = DatosCuenta[3];
                }
                if (DatosCuenta[4] != "")
                {
                    cuenta[0].email = DatosCuenta[4];
                }
                if (DatosCuenta[5] != "")
                {
                    cuenta[5].carrera = DatosCuenta[5];
                }
                return true;
            }
            return false;
        }

        public bool AgregarCursoCuenta(int RUTCuenta, int IDCurso, List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {
                if (!cuenta[0].cursosRealizados.Contains(IDCurso))
                {
                    cuenta[0].cursosRealizados.Add(IDCurso);
                    return true;
                }
            }
            return false;
        }

        public bool AgregarCursoProfesor(int RUTCuentaProfesor, int IDCurso, 
                                         List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuentaProfesor, TodasCuentas);
            if (cuenta.Count == 1)
            {
                if (!((Profesor)cuenta[0]).cursosEnsena.Contains(IDCurso))
                {
                    ((Profesor)cuenta[0]).cursosEnsena.Add(IDCurso);
                    return true;
                }
            }
            return false;
        }

        public bool BorrarApunte(int IDApunte, List<Apunte> TodosApuntes)
        {
            List<Apunte> apunte = BuscarApunteTodos(new object[] { IDApunte, "", "" }, TodosApuntes);
            if (apunte.Count == 1)
            {
                TodosApuntes.Remove(apunte[0]);
                return true;
            }
            return false;
        }

        //Borra la cuenta con sus apuntes
        public bool BorrarCuenta(int RUTCuenta, List<Cuenta> TodasCuentas, List<Apunte> TodosApuntes)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {
                for (int i = 0; i < cuenta[0].apuntesSubidos.Count; i++)
                {
                    BorrarApunte(cuenta[0].apuntesSubidos[i], TodosApuntes);
                }
                TodasCuentas.Remove(cuenta[0]);
                return true;
            }
            return false;
        }

        public bool ActualizarApunte(int IDApunte, string[] miDatos, List<Apunte> todosApuntes)
        {
            List<Apunte> miApunte = BuscarApunteTodos(new Object[] { IDApunte, "", "" }, todosApuntes);
            if (miApunte.Count == 1)
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
            return false;
        }

        public bool CrearCurso(Object[] DatosCurso, List<Curso> TodosCursos)
        {
            bool checkNombre = true;
            for (int i = 0; i < TodosCursos.Count; i++)
            {
                if (TodosCursos[i].nombreCurso == (string)DatosCurso[0])
                {
                    checkNombre = false;
                }
            }
            if (checkNombre)
            {
                TodosCursos.Add(new Curso((string)DatosCurso[0], (string)DatosCurso[1],
                                          (string)DatosCurso[2], (List<string>)DatosCurso[3]));
                return true;
            }
            return false;
        }

        public bool EditarCurso(int IDCurso, List<string> DatosCurso, List<Curso> TodosCursos)
        {
            List<Curso> curso = BuscarCurso(IDCurso, TodosCursos);
            if (curso.Count == 1)
            {
                if (DatosCurso[0] != "")
                {
                    curso[0].nombreCurso = DatosCurso[0];
                }
                if (DatosCurso[1] != "")
                {
                    curso[0].facultad = DatosCurso[1];
                }
                if (DatosCurso[2] != "")
                {
                    curso[0].carrera = DatosCurso[2];
                }
                if (DatosCurso[3] != "")
                {
                    if (!curso[0].topico.Contains(DatosCurso[3]))
                    {
                        curso[0].topico.Add(DatosCurso[3]);
                    }
                }
                if (DatosCurso[4] != "")
                {
                    if (curso[0].topico.Contains(DatosCurso[4]))
                    {
                        curso[0].topico.Remove(DatosCurso[4]);
                    }
                }
                return true;
            }
            return false;
        }

        public bool BorrarCurso(int IDCurso, List<Curso> TodosCursos)
        {
            List<Curso> curso = BuscarCurso(IDCurso, TodosCursos);
            if (curso.Count == 1)
            {
                TodosCursos.Remove(curso[0]);
                return true;
            }
            return false;
        }
    }
}
