using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema miSistema = new Sistema();

            miSistema.crearCurso();
            miSistema.crearCuenta();
            foreach(Cuenta i in miSistema.listaCuentas)
            {
                i.SubirApunte(new object[] { "titulo", miSistema.listaCursos[0], new List<string>() { "topico" }, "Carrera", "Contenido" }, miSistema.listaApuntes);
            }
            Console.ReadLine();
            miSistema.GuardarDatos();
            Console.ReadLine();
            //Console.ReadLine();
            //miSistema.CargarDatos();
            //Console.ReadLine();
            //foreach (Apunte i in miSistema.listaApuntes)
            //{
            //    i.ImprimirInfoSi();
            //}
            //Console.ReadLine();
        }
    }
}
