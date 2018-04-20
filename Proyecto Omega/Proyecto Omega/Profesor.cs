using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    class Profesor : Cuenta
    {
        public Profesor(int miId, string miNombre, string miApellido, string miNombreUsuario, string miClaveAcceso,
                     string miEmail, string miCarrera)
             : base(miId, miNombre, miApellido, miNombreUsuario, miClaveAcceso, miEmail, miCarrera) { }

        
    }
}
