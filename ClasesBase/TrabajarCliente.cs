using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        public Cliente TraerCliente()
        {
            Cliente cl = new Cliente();
            cl.Cli_Apellido = "";
            cl.Cli_Nombre = "";
            cl.Cli_Domicilio = "";
            cl.Cli_Email = "";
            cl.Cli_Telefono= "";
            
            return cl;
        }
    }
}
