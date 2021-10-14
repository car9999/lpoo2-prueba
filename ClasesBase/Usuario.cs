using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        //****VARIABLES****
        private int usu_Id;
        private string usu_ApellidoNombre;
        private string usu_NombreUsuario;
        private string usu_Contraseña;
        private int rol_Id;

        //****CONTRUCTORES****

        public Usuario() 
        { }

        public Usuario(int usu_Id, string usu_ApellidoNombre,
            string usu_NombreUsuario, string usu_Contraseña, int rol_Id)
        {
            this.usu_Id = usu_Id;
            this.usu_ApellidoNombre = usu_ApellidoNombre;
            this.usu_NombreUsuario = usu_NombreUsuario;
            this.usu_Contraseña = usu_Contraseña;
            this.rol_Id = rol_Id;
        }

        public Usuario(string usu_NombreUsuario, string usu_Contraseña, int rol_Id)
        {
            this.usu_NombreUsuario = usu_NombreUsuario;
            this.usu_Contraseña = usu_Contraseña;
            this.rol_Id = rol_Id;
        }
        

        //****GETS SETS****

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        

        public string Usu_Contraseña
        {
            get { return usu_Contraseña; }
            set { usu_Contraseña = value; }
        }
        

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
    }
}
