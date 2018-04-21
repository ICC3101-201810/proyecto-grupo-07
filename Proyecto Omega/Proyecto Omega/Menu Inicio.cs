﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Menu_Inicio
    {
        public void menuInicial()
        {
            Console.WriteLine("Bienvenido a tu plataforma de apuntes");
            Sistema sistema = new Sistema();
            while (true)
            {
                Console.Write("\nSi eres miembro inicia sesion o crea una para comenzar a " +
                              "disfrutar del mejor material de estudio" +
                              "\n1-Inicio Sesion" +
                              "\n2-Crear Cuenta Nueva");
                Console.Write("\nIngrese su opcion: "); string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    Console.Clear();
                    Console.Write("Ingrese usuario: "); string usuario = Console.ReadLine();
                    Console.Write("Ingrese contraseña: "); string contrasena = Console.ReadLine();
                    int Verificacion = sistema.verificarContrasena(usuario, contrasena);
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
                }
                if (opcion == "2")
                {
                    Console.WriteLine("Gracias por querer unirte a esta gran central de " +
                                      "estudio.");
                    Console.WriteLine("Se te solitcitaran tus datos a continuacion, porfavor " +
                                      "sigue las instrucciones");
                    sistema.crearCuenta();

                    paginaInicialEstudiante();

                }
                
            }
        }

        public void paginaInicialEstudiante()
        {
            Console.WriteLine("Hola");
        }
        public void paginaInicialProfesor()
        {

        }
        public void paginaInicialAdministrador()
        {

        }
    }
}
