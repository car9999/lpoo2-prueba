using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;

using System.Data;
using System.Data.SqlClient;

namespace DataWorker
{
    public static class UsuarioDataworker
    {
        public static Usuario loginUsuario(String username, String password)
        {
            // Establecemos cadena de conexion
            SqlConnection conn = new SqlConnection(DataWorker.Properties.Settings.Default.conectionString);

            // Generamos el comando a ejecutar
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE usu_NombreUsuario= '" +  username  + "' AND usu_Contraseña= '" + password + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            // Ejecutamos comando
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Obtenemos resultados
            da.Fill(dt);
            //convertimos a lista 

            Usuario user = null;

            //Si encontro 1 regitro entonces creara una instancia de usuario y si no usuario seguira siendo null
            foreach (DataRow row in dt.Rows)
            {
                user = new Usuario
                {
                    Usu_Id = int.Parse(row["usu_Id"].ToString()),
                    Usu_ApellidoNombre = row["usu_ApellidoNombre"].ToString(),
                    Usu_Contraseña = row["usu_Contraseña"].ToString(),
                    Usu_NombreUsuario = row["usu_NombreUsuario"].ToString(),
                    Rol_Id = int.Parse(row["rol_Id"].ToString())
                };
            }
            return user;
        }



    }

}
