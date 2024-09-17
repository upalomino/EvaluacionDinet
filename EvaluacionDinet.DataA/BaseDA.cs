using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionDinet.DataA
{
    public class BaseDA
    {
        public SqlConnection _connection;
        public SqlTransaction _transaction;
        public string connectionString = string.Empty;

        public BaseDA()
        {
            //SqlConnection cn
            //_connection = cn; 
            connectionString = ConfigurationManager.ConnectionStrings["Conexion_BD"].ConnectionString;
        }
    }
}
