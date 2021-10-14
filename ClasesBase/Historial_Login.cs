using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Historial_Login
    {
        private int log_Id;

        public int Log_Id
        {
            get { return log_Id; }
            set { log_Id = value; }
        }
        private int usu_Id;

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        private DateTime log_FechaHora;

        public DateTime Log_FechaHora
        {
            get { return log_FechaHora; }
            set { log_FechaHora = value; }
        }
        private string log_Descrip;

        public string Log_Descrip
        {
            get { return log_Descrip; }
            set { log_Descrip = value; }
        }
    }
}
