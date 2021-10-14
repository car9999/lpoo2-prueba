using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace DataWorker
{
  public class UnidadMedidaDataworker
    {
        public List<Unidad_Medida> listarUM()
        {

            // Establecemos cadena de conexion
            SqlConnection conn = new SqlConnection(DataWorker.Properties.Settings.Default.conectionString);

            // Generamos el comando a ejecutar
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Unidad_Medida";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            // Ejecutamos comando
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Obtenemos resultados
            da.Fill(dt);
            //convertimos a lista 
            List<Unidad_Medida> listUM = new List<Unidad_Medida>();

            foreach (DataRow row in dt.Rows)
            {
                Unidad_Medida um = new Unidad_Medida
                {
                    UM_Id1 = int.Parse(row["UM_Id"].ToString()),
                    UM_Descrip1 = row["UM_Descrip"].ToString(),
                    UM_Abrev1 = row["UM_Abrev"].ToString()
                };
                listUM.Add(um);
            }

            return listUM;
        }
    }
}
