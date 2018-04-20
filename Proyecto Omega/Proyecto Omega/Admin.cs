using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    class Admin : Cuenta
    {
        public Admin(string Nombre, string Apellido, string NombreUsuario, string ClaveAcceso, 
                     string Email, string Carrera) 
             : base(Nombre, Apellido, NombreUsuario, ClaveAcceso, Email, Carrera){}

    }
}
