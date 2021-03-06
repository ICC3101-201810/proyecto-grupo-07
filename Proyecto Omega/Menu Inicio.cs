﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Menu_Inicio
    {
        public Sistema sistema = new Sistema();

        public Menu_Inicio() // Lo primero es cargar los datos
        {
            sistema.CargarDatos();
        }

        public void MenuInicial()
        {
            Console.WriteLine("Bienvenido a tu plataforma de apuntes\n" +
                              "Recuerda ingresar '-1' como opcion para volver al menu anterior");
            while (true)
            {
                sistema.adminSistema = sistema.adminSistema.BuscarCuenta(1, sistema.listaCuentas)[0];
                Console.Write("\nSi eres miembro inicia sesion o crea una para comenzar a " +
                              "disfrutar del mejor material de estudio" +
                              "\n\n1-Inicio Sesion" +
                              "\n2-Crear Cuenta Nueva");
                Console.Write("\n\nIngrese su opcion: "); string opcion = Console.ReadLine();
                if (opcion == "1")
                { //Iniciar Sesion Start
                    Console.Clear();
                    Console.Write("Ingrese su RUT: "); ID = Console.ReadLine();
                    Console.Write("Ingrese contraseña: "); string contrasena = Console.ReadLine();
                    int Verificacion = sistema.VerificarContrasena(ID, contrasena);
                    Console.WriteLine(Verificacion);
                    if (Verificacion==10)
                    {
                        Console.WriteLine("\nEl usuario y la contraseña no coinciden.\n" +
                                          "Porfavor vuelva a ingresarla");
                        continue;
                    }
                    if (Verificacion == 11)
                    {
                        paginaInicialEstudiante();
                    }
                    if (Verificacion == 12)
                    {
                        paginaInicialProfesor();
                    }
                    if (Verificacion == 13)
                    {
                        paginaInicialAdministrador();
                    }
                } //Iniciar Sesion End
                if (opcion == "2")
                {
                    Console.WriteLine("Gracias por querer unirte a esta gran central de " +
                                      "estudio.");
                    Console.WriteLine("Se te solitcitaran tus datos a continuacion, porfavor " +
                                      "sigue las instrucciones");
                     if (sistema.crearCuenta())
                    {
                        Console.WriteLine("Cuenta creada con exito");
                    }
                }
            }
        }

        public void paginaInicialEstudiante()
        {
            //Cambiamos el Usuario en el sistema
            sistema.adminSistema = sistema.adminSistema.BuscarCuenta(Int32.Parse(ID),
                                                               sistema.listaCuentas)[0];
            string opcion = "0";
            while (!opcion.Equals("-1"))
            {
                Console.Clear();
                Console.Write("Seleccione una opcion\n\n" +
                              " 1-Crear un Apunte\n" +
                              " 2-Buscar un Apunte por ID\n" +
                              " 3-Cambiar uno de tus apuntes\n" +
                              " 4-Publicar/Despublicar uno de tus apuntes\n" +
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
                if (opcion == "1")
                {
                    sistema.subirApunte();
                }
                else if (opcion == "2")
                {
                    sistema.mostrarApunteID();
                }
                else if (opcion == "3")
                {
                    sistema.cambiarApunte();
                }
                else if (opcion == "4")
                {
                    sistema.publicarApunte();
                }
                else if (opcion == "5"|| opcion == "6" || opcion == "7" || opcion == "8" || 
                         opcion == "9" || opcion == "10" || opcion == "11" || opcion == "12" ||
                         opcion == "13" || opcion == "14" || opcion == "15" || opcion == "16")
                {
                    Console.WriteLine("Esta opcion aun no a sido implementada");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
        }
        public void paginaInicialProfesor()
        {
            sistema.adminSistema = sistema.adminSistema.BuscarCuenta(Int32.Parse(ID),
                                                               sistema.listaCuentas)[0];
            string opcion = "0";
            while (!opcion.Equals("-1"))
            {
                Console.Clear();
                Console.Write("Seleccione una opcion\n\n" +
                              " 1-Crear un Apunte\n" +
                              " 2-Buscar un Apunte por ID\n" +
                              " 3-Cambiar uno de tus apuntes\n" +
                              " 4-Publicar/Despublicar uno de tus apuntes\n" +
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
                if (opcion == "1")
                {
                    sistema.subirApunte();
                }
                else if (opcion == "2")
                {
                    sistema.mostrarApunteID();
                }
                else if (opcion == "3")
                {
                    sistema.cambiarApunte();
                }
                else if (opcion == "4")
                {
                    sistema.publicarApunte();
                }
                else if (opcion == "5" || opcion == "6" || opcion == "7" || opcion == "8" ||
                         opcion == "9" || opcion == "10" || opcion == "11" || opcion == "12" ||
                         opcion == "13" || opcion == "14" || opcion == "15" || opcion == "16")
                {
                    Console.WriteLine("Esta opcion aun no a sido implementada");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
        }
        public void paginaInicialAdministrador()
        {
            sistema.adminSistema = sistema.adminSistema.BuscarCuenta(Int32.Parse(ID),
                                                               sistema.listaCuentas)[0];
            string opcion = "0";
            while (!opcion.Equals("-1"))
            {
                Console.Clear();
                Console.Write("Seleccione una opcion\n\n" +
                          " 1-Crear un Apunte\n" +
                          " 2-Buscar un Apunte por ID\n" +
                          " 3-Cambiar un apunte\n" +
                          " 4-Publicar/Despublicar uno de tus apuntes\n" +
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
                if (opcion == "1")
                {
                    sistema.subirApunte();
                }
                else if (opcion == "2")
                {
                    sistema.mostrarApunteID();
                }
                else if (opcion == "3")
                {
                    sistema.cambiarApunte();
                }
                else if (opcion == "4")
                {
                    sistema.publicarApunte();
                }
                else if (opcion == "5" || opcion == "6" || opcion == "7" || opcion == "8" ||
                         opcion == "9" || opcion == "10" || opcion == "11" || opcion == "12" ||
                         opcion == "13" || opcion == "14" || opcion == "15" || opcion == "16")
                {
                    Console.WriteLine("Esta opcion aun no a sido implementada");
                }
                else if (opcion == "18")
                {
                    sistema.crearCuenta();
                }
                else if (opcion == "19")
                {
                    sistema.eliminarCuenta();
                }
                else if (opcion == "20")
                {
                    sistema.crearCurso();
                }
            }
        }
    }
}
