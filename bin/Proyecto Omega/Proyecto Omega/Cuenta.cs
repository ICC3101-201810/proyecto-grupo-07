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
        public int RUT;
        public List<int> apuntesSubidos = new List<int>() { };    // Lista de los ID de los apuntes
        public List<int> valoracionCuenta = new List<int>() { };  // que ha subido
        public List<int> cursosRealizados = new List<int>() { };
        public List<Cuenta> amigos = new List<Cuenta>() { };
        public List<Cuenta> cuentaFavoritos = new List<Cuenta>() { };
        public string carrera;
        public List<Reporte> reportes = new List<Reporte>() { };

        public Cuenta(int miRUT, string miNombre,string miApellido,string miNombreUsuario, 
                      string miClaveAcceso,string miEmail,string miCarrera)
        {
            nombre = miNombre;
            apellido = miApellido;
            nombreUsuario = miNombreUsuario;
            claveAcceso = miClaveAcceso;
            email = miEmail;
            carrera = miCarrera;
            RUT = miRUT;
        }

        public Apunte SubirApunte(Object[] miDatos)  // Recibe un array con todos los parametros
        {                                            // para crear un apunte
            Apunte miApunte = new Apunte(this, (string)miDatos[0], (Curso)miDatos[1], (List<string>)miDatos[2],
                             (string)miDatos[3], (string)miDatos[4]);
            apuntesSubidos.Add(miApunte.ID);
            Curso auxCurso = (Curso)miDatos[1];
            auxCurso.apuntes.Add(miApunte.ID);
            return miApunte;
        }

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
                    else if (todosApuntes[i].topico.Contains((string)miDatos[3]))
                    {
                        apuntes.Add(todosApuntes[i]);
                    }
                }
            }    
            return apuntes;
        }

        // Busca entre sus apuntes si existe el apunte a cambiar y luego revisa que se quiere cambiar
        public bool ActualizarApunte(int IDApunte, string[] miDatos, List<Apunte> todosApuntes)
        {   // Al buscar por ID a lo mas puede haber un resultado
            List<Apunte> miApunte = BuscarApunte(new Object[] { IDApunte, "", "" }, todosApuntes);
            if (miApunte.Count == 1)
            {
                if (miDatos[0] != "")                      // Se ve si hay datos a actualizar,
                {                                          // solo se puede actualizar uno a la vez.
                    miApunte[0].titulo = miDatos[0];       // Aqui solo se puede cambiar titulo, 
                    return true;                           // topicos (uno a la vez), carrera y contenido
                }                                          // los otros datos tienen otros metodos.
                else if (miDatos[2] != "")  // Agrega el topico si no lo tiene.
                {
                    if (!miApunte[0].topico.Contains(miDatos[2]))
                    {
                        miApunte[0].topico.Add(miDatos[2]);
                        return true;
                    }
                    return false;
                }
                else if (miDatos[3] != "")  // Borra el topico si lo tiene
                {
                    if (miApunte[0].topico.Contains(miDatos[3]))
                    {
                        miApunte[0].topico.Remove(miDatos[3]);
                        return true;
                    }
                    return false;
                }
                else if (miDatos[4] != "")
                {
                    miApunte[0].carrera = miDatos[4];
                    return true;
                }
                else if (miDatos[5] != "")
                {
                    miApunte[0].contenido = miDatos[5];
                    return true;
                }
            }
            return false;
        }

        //public Cuenta ReportarCuenta(Object[] datosBuscar)
        //{
        //      // Faltan los metodos relacionados con cuentas
        //}

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
                if (TodasCuentas[i].RUT == RUTCuenta)
                {
                    cuentaEncontrada.Add(TodasCuentas[i]);
                }
            }
            return cuentaEncontrada;  // Las unicas opciones son una lista de largo 0 o 1
        }


    }
}
