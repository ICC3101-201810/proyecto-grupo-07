using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    class Admin : Cuenta
    {
        public Admin(int miRut, string miNombre, string miApellido, string miNombreUsuario, string miClaveAcceso, 
                     string miEmail, string miTipo, int miCarrera) 
             : base(miRut, miNombre, miApellido, miNombreUsuario, miClaveAcceso, miEmail, miTipo, miCarrera){}

    }
}
