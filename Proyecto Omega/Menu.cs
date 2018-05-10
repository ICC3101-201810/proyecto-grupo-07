using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Menu
    {
        public Menu() { }

        public void MenuInicio()
        {
            Console.Write("Bienvenido a tu plataforma de apuntes \n\n" +
                          "Si eres miembro inicia sesion o crea una para comenzar a disfrutar del " +
                          "mejor material de estudio\n" +
                          "1-Inicio Sesion\n" +
                          "2-Crear Cuenta Nueva\n\n" +
                          "Opcion :");
        }

        public void MenuCuenta()
        {
            Console.Write("Seleccione una opcion\n\n" +
                          " 1-Crear un Apunte\n" +
                          " 2-Buscar un Apunte por ID\n" +
                          " 3-Cambiar uno de tus apuntes\n" +
                          " 4-Publicar uno de tus apuntes\n" +
                          " 5-Eliminar uno de tus apuntes\n" +
                          " 6-Mostrar los Cursos" +
                          " 7-Buscar los apuntes de un curso\n" +
                          " 8-Buscar apuntes por Titulo" +
                          " 9-Buscar apuntes por Topicos\n" +
                          "10-Reportar una Cuenta\n" +
                          "11-Reportar un Apunte\n" +
                          "12-Agregar un Amigo\n" +
                          "13-Eliminar un Amigo\n" +
                          "14-Agregar una Cuenta de Favoritos\n" +
                          "15-Eliminar una Cuenta de Favoritos\n" +
                          "16-Modificar tu Cuenta\n\n" +
                          "Opcion: ");
        }

        public void MenuAdmin()
        {
            Console.Write("Seleccione una opcion\n\n" +
                          " 1-Crear un Apunte\n" +
                          " 2-Buscar un Apunte por ID\n" +
                          " 3-Cambiar un apunte\n" +
                          " 4-Publicar uno de tus apuntes\n" +
                          " 5-Eliminar un apunte\n" +
                          " 6-Mostrar los Cursos" +
                          " 7-Buscar los apuntes de un curso\n" +
                          " 8-Buscar apuntes por Titulo" +
                          " 9-Buscar apuntes por Topicos\n" +
                          "10-Reportar una Cuenta\n" +
                          "11-Reportar un Apunte\n" +
                          "12-Agregar un Amigo\n" +
                          "13-Eliminar un Amigo\n" +
                          "14-Agregar una Cuenta de Favoritos\n" +
                          "15-Eliminar una Cuenta de Favoritos\n" +
                          "16-Modificar una Cuenta\n" +
                          "17-Agregar a una Cuenta un Curso aprobado\n" +
                          "18-Crear una Cuenta\n" +
                          "19-Borrar una Cuenta\n" +
                          "20-Crear un Curso\n" +
                          "21-Cambiar un Curso\n" +
                          "22-Borrar un Curso\n\n" +
                          "Opcion: ");
        }


    }
}
