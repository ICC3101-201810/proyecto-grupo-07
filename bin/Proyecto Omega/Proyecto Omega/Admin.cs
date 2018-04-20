using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    class Admin : Cuenta
    {
        public Admin(int RUT ,string Nombre, string Apellido, string NombreUsuario, string ClaveAcceso, 
                     string Email, string Carrera) 
             : base(RUT, Nombre, Apellido, NombreUsuario, ClaveAcceso, Email, Carrera){ }

        public bool CrearCuenta(Object[] DatosCuenta, List<Cuenta> TodasCuentas)
        {
            bool checkRUT = true;
            for (int i = 0; i < TodasCuentas.Count; i++)
            {
                if (TodasCuentas[i].RUT == (int)DatosCuenta[0]) // Se revisa que no haya una cuenta
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

        public bool modificarCuenta(int RUTCuenta, Object[] DatosCuenta, List<Cuenta> TodasCuentas)
        {
            List<Cuenta> cuenta = BuscarCuenta(RUTCuenta, TodasCuentas);
            if (cuenta.Count == 1)
            {

            }
        }
        
    }
}
