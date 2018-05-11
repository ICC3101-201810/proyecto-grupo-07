using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class PruebaEnConsola
    {
        public List<Curso> Cursos = new List<Curso>() { };
        public List<Apunte> Apuntes = new List<Apunte>() { };
        public List<Cuenta> Cuentas = new List<Cuenta>() { };

        public Sistema Sistema = new Sistema();

        public PruebaEnConsola() { }

        public void Probar()
        {
            CrearCuenta();
            Console.WriteLine(Cuentas[0].Info());
            Console.ReadLine();

            
        }

        public void CrearCuenta()
        {
            Console.WriteLine("Cuentas:");
            int[] auxRut;
            string[] auxNombre;
            string[] auxApellido;
            string[] auxContrasena;
            string[] auxEmail;
            string[] auxCarrera;
            do
            {
                Console.Write("Ingrese Rut: ");
                string Rut_ = Console.ReadLine();
                auxRut = Sistema.Ingresar.Rut(Rut_);
                if (auxRut.Count() == 0)
                {
                    Console.WriteLine("Invalido: ");
                }
            } while (auxRut.Count() == 0);
            do
            {
                Console.Write("Ingrese Nombre: ");
                auxNombre = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxRut.Count() == 0);
            do
            {
                Console.Write("Ingrese Apellido: ");
                auxApellido = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxRut.Count() == 0);
            do
            {
                Console.Write("Ingrese Contrasena: ");
                auxContrasena = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxRut.Count() == 0);
            do
            {
                Console.Write("Ingrese Email: ");
                auxEmail = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxRut.Count() == 0);
            do
            {
                Console.Write("Ingrese Carrera: ");
                auxCarrera = Sistema.Ingresar.String(Console.ReadLine());
            } while (auxRut.Count() == 0);
            if (Sistema.Buscar.Cuenta("Rut", auxRut[0], Cuentas).Count() == 0)
            {
                Cuentas.Add(new Cuenta(auxRut[0], auxNombre[0], auxApellido[0], auxContrasena[0],
                                       auxEmail[0], auxCarrera[0]));
            }
        }


    }
}
