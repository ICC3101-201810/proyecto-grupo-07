using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Existe //Obsoleto, buscar entrega una lista vacia si no existe lo que se busca
    {
        public Existe() { }

        public bool Curso(int IDCurso, List<Curso> ListaCursos)
        {
            if(ListaCursos.Any(x => x.getID() == IDCurso))
            {
                return true;
            }
            return false;
        }

        public bool Apunte(int IDApunte, List<Apunte> ListaApuntes)
        {
            if (ListaApuntes.Any(x => x.getID() == IDApunte))
            {
                return true;
            }
            return false;
        }

        public bool Cuenta(int RUTCuenta, List<Cuenta> ListaCuentas)
        {
            if (ListaCuentas.Any(x => x.getRut() == RUTCuenta))
            {
                return true;
            }
            return false;
        }
    }
}
