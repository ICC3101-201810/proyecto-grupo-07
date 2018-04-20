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

            miSistema.crearCuenta();
            foreach(Cuenta i in miSistema.listaCuentas)
            {
                Console.WriteLine("{0}", i.nombre);
            }
            Console.ReadLine();
        }
    }
}
