using EvaluacionDinet.DataA;
using EvaluacionDinet.EntidadA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionDinet.NegocioA
{
    public class MovimientoBL
    {
        public List<MovimientoBE> Buscar(FiltroMovimientoBE filtros)
        {
            try
            {
                return new MovimientoDA().Buscar(filtros);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool Insertar(MovimientoBE entidad)
        {
            try
            {
                return new MovimientoDA().Registrar(entidad);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
