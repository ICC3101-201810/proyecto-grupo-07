using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Cuenta
    {
        public string nombre;
        public string apellido;
        public string nombreUsuario;
        public string claveAcceso;
        public string email;
        public int ID;
        public List<int> apuntesSubidos = new List<int>() { };    // Lista de los ID de los apuntes
        public List<int> valoracionCuenta = new List<int>() { };  // que ha subido
        public List<int> cursosRealizados = new List<int>() { 1};  // ID de cursos
        public List<int> amigos = new List<int>() { };
        public List<int> favoritos = new List<int>() { };
        public string carrera;
        public List<int> reportes = new List<int>() { };

        public Cuenta(int miRUT, string miNombre,string miApellido,string miNombreUsuario, 
                      string miClaveAcceso,string miEmail,string miCarrera)
        {
            nombre = miNombre;
            apellido = miApellido;
            nombreUsuario = miNombreUsuario;
            claveAcceso = miClaveAcceso;
            email = miEmail;
            carrera = miCarrera;
            ID = miRUT;
        }

        public void CargarDatos(List<int> miApuntesSubidos, List<int> miValoracionCuenta, 
                                List<int> miCursosRealizados, List<int> miAmigos, 
                                List<int> miFavoritos, List<int> miReporte)
        {
            apuntesSubidos = miApuntesSubidos;
            valoracionCuenta = miValoracionCuenta;
            cursosRealizados = miCursosRealizados;
            amigos = miAmigos;
            favoritos = miFavoritos;
            reportes = miReporte;
        }

        public bool SubirApunte(Object[] miDatos, List<Apunte> TodosApuntes)  
        {
            Curso auxCurso = (Curso)miDatos[1];
            if (cursosRealizados.Contains(auxCurso.ID))
            {
                Apunte miApunte = new Apunte(this, (string)miDatos[0], (Curso)miDatos[1], (List<string>)miDatos[2],
                                 (string)miDatos[3], (string)miDatos[4]);
                apuntesSubidos.Add(miApunte.ID);
                auxCurso.apuntes.Add(miApunte.ID);
                TodosApuntes.Add(miApunte);
                Console.WriteLine("SI");
                return true;
            }
            return false;
        }

        //Busca solo en los apuntes que ha subido
        public List<Apunte> BuscarApunte(Object[] miDatos, List<Apunte> todosApuntes) 
                                // Recibe un array [ID, titulo, topico] y la lista de todos los apuntes
        {                       //                 [int, string, string]
            List<Apunte> apuntes = new List<Apunte>() { };
            for (int i = 0; i < todosApuntes.Count; i++)
            {
                if (apuntesSubidos.Contains(todosApuntes[i].ID))  // Revisa si la cuenta fue la que subio
                {                                                 // ese apunte
                    if (todosApuntes[i].ID == (int)miDatos[0])
                    {
                        apuntes.Add(todosApuntes[i]);
                    }
                    else if (todosApuntes[i].titulo == (string)miDatos[1])
                    {
                        apuntes.Add(todosApuntes[i]);
                    }
                    else if (todosApuntes[i].topico.Contains((string)miDatos[2]))
                    {
                        apuntes.Add(todosApuntes[i]);
                    }
                }
            }    
            return apuntes;
        }

        //Busca entre todos los apuntes
        public List<Apunte> BuscarApunteTodos(Object[] miDatos, List<Apunte> todosApuntes)
        {
            List<Apunte> apuntes = new List<Apunte>() { };
            for (int i = 0; i < todosApuntes.Count; i++)
            {                                            
                if (todosApuntes[i].ID == (int)miDatos[0])
                {
                    apuntes.Add(todosApuntes[i]);
                }
                else if (todosApuntes[i].titulo == (string)miDatos[1])
                {
                    apuntes.Add(todosApuntes[i]);
                }
                else if (todosApuntes[i].topico.Contains((string)miDatos[3]))
                {
                    apuntes.Add(todosApuntes[i]);
                }
            }
            return apuntes;
        }

        // Busca entre sus apuntes si existe el apunte a cambiar y luego revisa que se quiere cambiar
        public bool ActualizarApunte(int IDApunte, Object[] miDatos, List<Apunte> todosApuntes)
        {   // Al buscar por ID a lo mas puede haber un resultado
            List<Apunte> miApunte = BuscarApunte(new Object[] { IDApunte, "", "" }, todosApuntes);
            if (miApunte.Count == 1)
            {
                if ((string)miDatos[0] != "")                      // Se ve si hay datos a actualizar
                {                                        
                    miApunte[0].titulo = (string)miDatos[0];     // Aqui solo se puede cambiar titulo, 
                                                                 // topicos, carrera y contenido
                }                                                // los otros datos tienen otros metodos.
                foreach (string i in (List<string>)miDatos[1])   // Agrega el topico si no lo tiene.
                {
                    if (!miApunte[0].topico.Contains(i))
                    {
                        miApunte[0].topico.Add(i);
                    }
                }
                foreach (string i in (List<string>)miDatos[2])  // Borra el topico si lo tiene
                {
                    if (miApunte[0].topico.Contains(i))
                    {
                        miApunte[0].topico.Remove(i);
                    }
                }
                if ((string)miDatos[3] != "")
                {
                    miApunte[0].carrera = ((string)miDatos[3]);
                }
                if ((string)miDatos[4] != "")
                {
                    miApunte[0].contenido = ((string)miDatos[4]);
                }
                return true;
            }
            return false;
        }

        public bool PublicarApunte(int IDApunte, bool miEstado, List<Apunte> todosApuntes)
        {
            List<Apunte> apunte = BuscarApunte(new Object[] { IDApunte, "", "" }, todosApuntes);
            if (apunte.Count == 1)                  // Al buscar por ID nunca vamos a tener mas de un
            {                                       // resultado.
                if (apunte[0].publico != miEstado)  // Ve si se intenta cambiar al mismo estado anterior
                {
                    apunte[0].publico = miEstado;
                    return true;
                }
            }
            return false;
        }

        public bool EliminarApunte(int IDApunte, List<Apunte> todosApuntes)
        {
            List<Apunte> apunte = BuscarApunte(new Object[] { IDApunte, "", "" }, todosApuntes);
            if (apunte.Count == 1)                  // Al buscar por ID nunca vamos a tener mas de un
            {                                       // resultado.
                apuntesSubidos.Remove(IDApunte);
                apunte[0].curso.apuntes.Remove(IDApunte);
                todosApuntes.Remove(apunte[0]);
                return true;
            }
            return false;
        }

        public List<Cuenta> BuscarCuenta(int RUTCuenta, List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuentaEncontrada = new List<Cuenta>() { };
            for (int i = 0; i < TodasCuentas.Count; i++)
            {
                if (TodasCuentas[i].ID == RUTCuenta)
                {
                    cuentaEncontrada.Add(TodasCuentas[i]);
                }
            }
            return cuentaEncontrada;  // Las unicas opciones son una lista de largo 0 o 1
        }

        public List<Reporte> BuscarReporte(int IDReporte, List<Reporte> TodosReportes)
        {
            List<Reporte> reporteEncontrado = new List<Reporte>() { };
            for (int i = 0; i < TodosReportes.Count; i++)
            {
                if (TodosReportes[i].ID == IDReporte)
                {
                    reporteEncontrado.Add(TodosReportes[i]);
                }
            }
            return reporteEncontrado;  // Las unicas opciones son una lista de largo 0 o 1
        }

        public bool ReportarCuenta(int RUTCuenta, string RazonReporte, List<Cuenta> TodasCuentas, 
                                   List<Reporte> TodosReportes)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {
                Reporte auxReporte = new Reporte(this, RazonReporte);
                cuenta[0].reportes.Add(auxReporte.ID);
                TodosReportes.Add(auxReporte);
                return true;
            }
            return false;
        }

        public bool ReportarApunte(int IDApunte, List<Apunte> TodosApuntes, string RazonReporte)
        {
            List<Apunte> apunte = BuscarApunteTodos(new Object[] { IDApunte, "", "" }, TodosApuntes);
            if (apunte.Count == 1)
            {
                apunte[0].reportes.Add(new Reporte(this, RazonReporte));
                return true;
            }
            return false;
        }

        public bool AgregarAmigo(int RUTCuenta, List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {
                if (!amigos.Contains(cuenta[0].ID))
                {
                    amigos.Add(cuenta[0].ID);
                    return true;
                }
            }
            return false;
        }

        public bool EliminarAmigo(int RUTCuenta, List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {
                if (amigos.Contains(cuenta[0].ID))
                {
                    amigos.Remove(cuenta[0].ID);
                    return true;
                }
            }
            return false;
        }

        public bool AgregarFavorito(int RUTCuenta, List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {
                if (!favoritos.Contains(cuenta[0].ID))
                {
                    favoritos.Add(cuenta[0].ID);
                    return true;
                }
            }
            return false;
        }

        public bool EliminarFavorito(int RUTCuenta, List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {
                if (!favoritos.Contains(cuenta[0].ID))
                {
                    favoritos.Add(cuenta[0].ID);
                    return true;
                }
            }
            return false;
        }

        public List<Curso> BuscarCurso(int IDCurso, List<Curso> TodosCursos)
        {
            List<Curso> curso = new List<Curso>() { };
            for (int i = 0; i < TodosCursos.Count; i++)
            {
                if (TodosCursos[i].ID == IDCurso)
                {
                    curso.Add(TodosCursos[i]);
                }
            }
            return curso;
        }

        public void modificarCuenta(List<string> DatosCuenta)
        {
            if (DatosCuenta[0] != "")
            {
                nombre = DatosCuenta[0];
            }
            if (DatosCuenta[1] != "")
            {
                apellido = DatosCuenta[1];
            }
            if (DatosCuenta[2] != "")
            {
                nombreUsuario = DatosCuenta[2];
            }
            if (DatosCuenta[3] != "")
            {
                claveAcceso = DatosCuenta[3];
            }
            if (DatosCuenta[4] != "")
            {
                email = DatosCuenta[4];
            }
            if (DatosCuenta[5] != "")
            {
                carrera = DatosCuenta[5];
            }
        }

    }
}
