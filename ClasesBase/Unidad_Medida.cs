using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Unidad_Medida
    {
        private int UM_Id;

        public int UM_Id1
        {
            get { return UM_Id; }
            set { UM_Id = value; }
        }
        private string UM_Descrip;

        public string UM_Descrip1
        {
            get { return UM_Descrip; }
            set { UM_Descrip = value; }
        }
        private string UM_Abrev;

        public string UM_Abrev1
        {
            get { return UM_Abrev; }
            set { UM_Abrev = value; }
        }
    }
}
