using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace ClasesBase
{
    public class Cliente: IDataErrorInfo{ 
        
        private int cli_Id;

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }
        private string cli_Apellido;

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }
        private string cli_Nombre;

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
        private string cli_Domicilio;

        public string Cli_Domicilio
        {
            get { return cli_Domicilio; }
            set { cli_Domicilio = value; }
        }
        private string cli_Telefono;

        public string Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }
        private string cli_Email;

        public string Cli_Email
        {
            get { return cli_Email; }
            set { cli_Email = value; }
        }

        public String Error
        {
            get{ throw new NotImplementedException(); }
        }


        public string this[String columnName]
        {
            get{
                string result = null;
                if (columnName == "Cli_Id")
                {
                    if (cli_Id==null)
                    {
                        return "El campo Cliente ID es obligatorio";
                    }

                    if ( cli_Id <= 0)
                    {
                        return "El cliente ID debe ser mayor a Cero";
                    }
                }

                if (columnName == "Cli_Apellido")
                {
                    if (String.IsNullOrEmpty(cli_Apellido))
                        return "El campo apellido no puede estar vacio";
                    if (cli_Apellido.Any(x => char.IsNumber(x)))
                        return "Este campo no puede contener Numeros";   
                }


                if (columnName == "Cli_Nombre")
                {
                    if (String.IsNullOrEmpty(cli_Nombre))
                        return "El campo nombre no puede estar vacio";
                    if (cli_Nombre.Any(x => char.IsNumber(x)))
                        return "Este campo no puede contener Numeros";
                }


                if (columnName == "Cli_Telefono")
                {
                    if (String.IsNullOrEmpty(cli_Telefono))
                        return "Este campo es obligatorio";
                    if (cli_Telefono.Any(x => char.IsLetter(x)))
                        return "Este campo no puede contener letras";
                }
                  return result;
            }
        }
    }
}
