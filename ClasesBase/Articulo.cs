using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    /**Esta clase representa un tipo de articulo que posee la empresa para su funcionamiento como negocio**/
    public class Articulo
    {
        private int art_Id;

        public int Art_Id
        {
            get { return art_Id; }
            set { art_Id = value; }
        }
        private string art_Descrip;

        public string Art_Descrip
        {
            get { return art_Descrip; }
            set { art_Descrip = value; }
        }
        private string fam_Id;

        public string Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; }
        }
        private string UM_Id;

        public string UM_Id1
        {
            get { return UM_Id; }
            set { UM_Id = value; }
        }
        private decimal art_Precio;

        public decimal Art_Precio
        {
            get { return art_Precio; }
            set { art_Precio = value; }
        }
        private Boolean art_ManejaStock;

        public Boolean Art_ManejaStock
        {
            get { return art_ManejaStock; }
            set { art_ManejaStock = value; }
        }
    }
}
