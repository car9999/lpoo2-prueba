using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for WinClientes.xaml
    /// </summary>
    public partial class WinClientes : Window
    {
        public TrabajarCliente cl;

        public WinClientes()
        {
            InitializeComponent();
        }

        private void btnVolverPrincipal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
           // if (txtApellido.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtDomicilio.Text.Trim() == "" || txtTelefono.Text.Trim() == "" || txtEmail.Text.Trim() == "")
            //{
              //  MessageBox.Show("No puede tener campos vacios", "", MessageBoxButton.OK, MessageBoxImage.Error);
            //}else
            {
                Cliente cliente = new Cliente();
                MessageBoxResult result;
                result = MessageBox.Show("Guardar los campos?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.OK)
                {
                    crearCliente(cliente);
                    MessageBox.Show(encadenarDatosCliente(cliente), "ARTICULO GUARDADO", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiarForm();
                }
            }
        }

        private void crearCliente(Cliente cliente)
        {
            cliente.Cli_Apellido = txtApellido.Text;
            //cliente.Cli_Nombre = txtNombre.Text;
            //cliente.Cli_Domicilio = txtDomicilio.Text;
            //cliente.Cli_Telefono = txtTelefono.Text;
        //    cliente.Cli_Email = txtEmail.Text;
        }

        private void limpiarForm()
        {
            txtApellido.Text="";
          //  txtNombre.Text="";
            //txtDomicilio.Text="";
            //txtTelefono.Text="";
            //txtEmail.Text ="";
        }

        private string encadenarDatosCliente(Cliente cliente)
        {
            string sCadenaDatosArticulo = "DATOS: \n\n" +
                                              "Apellido: " + cliente.Cli_Apellido + "\n" +
                                              "Nombre: " + cliente.Cli_Nombre + "\n" +
                                              "Domicilio: " + cliente.Cli_Domicilio + "\n" +
                                              "Telefono: " + cliente.Cli_Telefono + "\n" +
                                              "Email: " + cliente.Cli_Email + "\n";
            return sCadenaDatosArticulo;
        }
    }
}
