using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /// <summary>
    /// Clase roles del sistema : administrador, mozo , vendedor
    /// </summary>
    public class Roles
    {
        //****VARIABLES****
        private int rol_Id;
        private string rol_Descrip;



        //****CONTRUCTORES****
        public Roles()
        {
        }


        //****GETS SETS****
        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }
        public string Rol_Descrip
        {
            get { return rol_Descrip; }
            set { rol_Descrip = value; }
        }
    }
}
