using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;
namespace DataWorker
{
    public class FamiliaDataworker
    {

       


        public List<Familia> listarFamilias()
        {

            // Establecemos cadena de conexion
            SqlConnection conn = new SqlConnection(DataWorker.Properties.Settings.Default.conectionString);

            // Generamos el comando a ejecutar
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Familia";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            // Ejecutamos comando
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Obtenemos resultados
            da.Fill(dt);
           //convertimos a lista 
            List<Familia> listFamily = new List<Familia>();

            foreach (DataRow row in dt.Rows)
            {
                Familia f = new Familia
                {
                    Fam_Id = int.Parse(row["fam_Id"].ToString()),
                    Fam_Descrip = row["fam_Descrip"].ToString()
                };
                listFamily.Add(f);
            }

            return listFamily;
        }
    }
}
