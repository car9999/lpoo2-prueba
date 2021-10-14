using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace DataWorker
{
    public class articulosDataworker
    {

        public DataTable traerArticulos()
        {
            // Establecemos cadena de conexion
            SqlConnection conn = new SqlConnection(DataWorker.Properties.Settings.Default.conectionString);

            // Generamos el comando a ejecutar
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ArticulosConDetalles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            // Ejecutamos comando
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Obtenemos resultados
            da.Fill(dt);

            return (dt);
        }

       
    }
}
