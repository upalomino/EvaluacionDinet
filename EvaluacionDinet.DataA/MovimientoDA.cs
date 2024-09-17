using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EvaluacionDinet.EntidadA;


namespace EvaluacionDinet.DataA
{
    public class MovimientoDA : BaseDA
    {
        public List<MovimientoBE> Buscar(FiltroMovimientoBE filtros)
        {
            List<MovimientoBE> listaMovimiento = new List<MovimientoBE>();
            try
            {
                using (SqlConnection cn = new SqlConnection(base.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_MOV_INVENTARIO_BUSCAR", cn);
                    cmd.Parameters.AddWithValue("@FechaInicio", filtros.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", filtros.FechaFin);
                    cmd.Parameters.AddWithValue("@TipoMovimiento", filtros.TipoMovimiento);
                    cmd.Parameters.AddWithValue("@NroDocumento", filtros.NumeroDocumento);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MovimientoBE entidad = new MovimientoBE();
                            entidad.COD_CIA = reader.GetString(reader.GetOrdinal("COD_CIA"));
                            entidad.COMPANIA_VENTA_3 = reader.GetString(reader.GetOrdinal("COMPANIA_VENTA_3"));
                            entidad.ALMACEN_VENTA = reader.GetString(reader.GetOrdinal("ALMACEN_VENTA"));
                            entidad.TIPO_MOVIMIENTO = reader.GetString(reader.GetOrdinal("TIPO_MOVIMIENTO"));
                            entidad.TIPO_DOCUMENTO = reader.GetString(reader.GetOrdinal("TIPO_DOCUMENTO"));
                            entidad.NRO_DOCUMENTO = reader.GetString(reader.GetOrdinal("NRO_DOCUMENTO"));
                            entidad.COD_ITEM_2 = reader.GetString(reader.GetOrdinal("COD_ITEM_2"));
                        }
                        reader.Close();
                    }
                }
                return listaMovimiento;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool Registrar(MovimientoBE entidad)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(base.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_MOV_INVENTARIO_INSERTAR", cn);
                    cmd.Parameters.AddWithValue("@COD_CIA", entidad.COD_CIA);
                    cmd.Parameters.AddWithValue("@COMPANIA_VENTA_3", entidad.COMPANIA_VENTA_3);
                    cmd.Parameters.AddWithValue("@TIPO_MOVIMIENTO", entidad.TIPO_MOVIMIENTO);
                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO", entidad.TIPO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("@NRO_DOCUMENTO", entidad.NRO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("@COD_ITEM_2", entidad.COD_ITEM_2);
                    cmd.Parameters.AddWithValue("@PROVEEDOR", entidad.PROVEEDOR);
                    cmd.Parameters.AddWithValue("@ALMACEN_DESTINO", entidad.ALMACEN_DESTINO);
                    cmd.Parameters.AddWithValue("@CANTIDAD", entidad.CANTIDAD);
                    cmd.Parameters.AddWithValue("@COMPANIA_DESTINO", entidad.COMPANIA_DESTINO);
                    cmd.Parameters.AddWithValue("@COSTO_UNITARIO", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@DOC_REF_1", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@DOC_REF_2", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@FECHA_TRANSACCION", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@MOTIVO", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@PRECIO_UNITARIO", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@TIPO_DOC_REF", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@UM_ITEM_3", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@NRO_NOTA", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@ROWVERSION", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@USUARIO", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@MONEDA", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@COSTO_UNITARIO_ME", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@COS_UNIT_EST", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@COS_UNIT_ME_EST", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@HORA_TRANSACCION", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@F_ORDENCOMPRA", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@C_SEC_OC", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@C_SEC_DET_OC", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@TIPO_DOC_REF_2", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@OBSERVACION", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@FECHA_VALORIZACION", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@USUARIO_VALORIZA", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@FACTOR", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@COSTOS_ADICIONALES", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@T_CAMBIO_VALORIZA", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@PERIODO_CERRADO", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@PLANILLA_CONSIGNA", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@DOC_REF_3", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@INGRESO_SALIDA", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@SALDO_FINAL", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@FLAG_URGENTE", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@DOC_REF_4", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@DOC_REF_5", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@DOC_REF_6", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@DOC_REF_7", entidad.COSTO_UNITARIO);
                    cmd.Parameters.AddWithValue("@DOC_REF_8", entidad.COSTO_UNITARIO);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter resultado = new SqlParameter("@Resultado", SqlDbType.Int);
                    resultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultado);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    if (Convert.ToInt32(resultado.ToString()) == 1)
                        return true;

                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
