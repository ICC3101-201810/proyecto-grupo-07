using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    [Serializable()]
    public class Admin : Cuenta
    {
        public Admin(int miRut, string miNombre, string miApellido, string miContrasena,
                     string miEmail, string miCarrera) : base(miRut, miNombre, miApellido,
                      miContrasena, miEmail, miCarrera)
        { }

        //public Estudiante

    }
}
