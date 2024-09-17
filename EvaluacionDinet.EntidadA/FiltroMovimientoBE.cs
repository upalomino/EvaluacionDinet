using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionDinet.EntidadA
{
    public class FiltroMovimientoBE
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string TipoMovimiento { get; set; }
        public string NumeroDocumento { get; set; }
    }
}
