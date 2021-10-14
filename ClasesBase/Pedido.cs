using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClasesBase
{
    /**Clase que representa a un pedido que puede realizar un cliente en el restaurante**/
    public class Pedido
    {
        //****VARIABLES****
        private int ped_Id;
        private int usu_Id;
        private int mesa_Id;
        private int cli_Id;
        private DateTime ped_FechaEmision;
        private DateTime ped_FechaEntrega;
        private int ped_Comensales;
        private bool ped_Facturado;


        //****CONTRUCTORES****
        public Pedido() { 
        }

        //****GETS SETS****
        public int Ped_Id
        {
            get { return ped_Id; }
            set { ped_Id = value; }
        }
        

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        

        public int Mesa_Id
        {
            get { return mesa_Id; }
            set { mesa_Id = value; }
        }
        

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }
        

        public DateTime Ped_FechaEmision
        {
            get { return ped_FechaEmision; }
            set { ped_FechaEmision = value; }
        }
        

        public DateTime Ped_FechaEntrega
        {
            get { return ped_FechaEntrega; }
            set { ped_FechaEntrega = value; }
        }
        

        public int Ped_Comensales
        {
            get { return ped_Comensales; }
            set { ped_Comensales = value; }
        }
        

        public bool Ped_Facturado
        {
            get { return ped_Facturado; }
            set { ped_Facturado = value; }
        }
    }
}
