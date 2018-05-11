using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Estudiante : Cuenta
    {
        public Estudiante(int miRut, string miNombre, string miApellido, string miContrasena,
                        string miEmail, string miCarrera) : base(miRut, miNombre, miApellido, miContrasena,
                        miEmail, miCarrera) { }

    }
}
