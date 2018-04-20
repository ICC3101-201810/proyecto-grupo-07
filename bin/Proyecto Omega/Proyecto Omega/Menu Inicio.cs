using System;
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
            while (true)
            {
                Console.Write("Bienvenido a tu plataforma de apuntes \n" +
                  "Si eres miembro inicia sesion o crea una para comenzar a disfrutar del mejor material de estudio\n" +
                  "1-Inicio Sesion\n" +
                  "2-Crear Cuenta Nueva\n"
                  );
                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    Console.Clear();
                    Console.Write("Ingrese usuario: "); string usuario = Console.ReadLine();
                    Console.Write("Ingrese contraseña: "); string contrasena = Console.ReadLine();


                }
                
            }
        }

        public void inicioSesion()
        {

        }
    }
}
