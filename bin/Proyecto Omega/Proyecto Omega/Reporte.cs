using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Omega
{
    public class Reporte
    {
        private static int m_Counter = 0;

        public int ID { get; set; }

        public Cuenta reportador;
        public string razon;

        public Reporte(Cuenta miReportador, string miRazon)
        {
            reportador = miReportador;
            razon = miRazon;
            ID = System.Threading.Interlocked.Increment(ref m_Counter);
        }
    }
}
