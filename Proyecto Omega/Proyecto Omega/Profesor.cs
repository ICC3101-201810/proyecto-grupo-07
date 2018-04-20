using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    class Profesor : Cuenta
    {
        public Profesor(string Nombre, string Apellido, string NombreUsuario, string ClaveAcceso,
                     string Email, string Carrera)
             : base(Nombre, Apellido, NombreUsuario, ClaveAcceso, Email, Carrera) { }

        public void BorrarApunte(Apunte)
        {
            
        }
    }
}
