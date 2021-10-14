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
using System.Windows.Threading;
using Vistas.user_control;
using Vistas.user_control.mesa;
using Vistas.user_control.Articulo;
using Vistas.user_control.familia;
using Vistas.user_control.um;
using Vistas.user_control.categoria;
namespace Vistas
{
    /// <summary>
    /// Interaction logic for WinPrincipal.xaml
    /// </summary>
    public partial class WinPrincipal : Window
    {
        private static WinPrincipal _instancia;
        public WinPrincipal()
        {
            InitializeComponent();
        }
        public static WinPrincipal GetInstancia()
        {

            if (_instancia == null)
                _instancia = new WinPrincipal();

            return _instancia;
        }

        private void OpenInPanel(UserControl element)
        {
           
            if (pnlContenedor.Children.Count > 0)
                pnlContenedor.Children.Clear();
            pnlContenedor.Children.Add(element);
        }

        /// <summary>
        /// Muestra la ventana de  MESAS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            UCmesas mesa = UCmesas.GetInstance();
            OpenInPanel(mesa);
        }

        /// <summary>
        /// metodo Loaded del la ventana principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Usuario oUsuario = TrabajarUsuario.usuario_logueado;
            mostrarFuncionesSegunRol(oUsuario.Rol_Id);
            string fecha = DateTime.Now.ToShortDateString();
            //txtFecha.Text = fecha;
        }

        /// <summary>
         //mustra las opciones del menu segun el rol de usuario
         //</summary>
         //<param name="rol"></param>
        private void mostrarFuncionesSegunRol(int rol)
        {
            switch (rol)
            {
                case 1:
                    menuAdministrador();
                    break;
                case 2:
                    menuMozoVendedor();
                    break;
                case 3:
                    menuMozoVendedor();
                    break;
                default: break;
            }
        }
         //<summary>
         //Muestra solo las opciones de Menu para el Administrador
         //</summary>
        private void menuAdministrador()
        {
            var bc = new BrushConverter();
            ClientesMenuPrincipal.IsEnabled = false;
            lbClient.Foreground = (Brush)bc.ConvertFrom("#707070");
            MesasMenuPrincipal.IsEnabled = false;
            lblMesas.Foreground = (Brush)bc.ConvertFrom("#707070");
            VentasMenuPrincipal.IsEnabled = false;
            lblVentas.Foreground = (Brush)bc.ConvertFrom("#707070");
        }

        /// <summary>
        /// Muestra solo las opciones de menu para mozo y vendedor
        /// </summary>
        private void menuMozoVendedor()
        {
            var bc = new BrushConverter();
            UsuariosMenuPrincipal.IsEnabled = false;
            lblUsuario.Foreground = (Brush)bc.ConvertFrom("#707070");
            ArticulosMenuPrincipal.IsEnabled = false;
            lblArticulo.Foreground = (Brush)bc.ConvertFrom("#707070");
            FamiliaMenuPrincipal.IsEnabled = false;
            lblFamilia.Foreground = (Brush)bc.ConvertFrom("#707070");
            CategoriasMenuPrincipal.IsEnabled = false;
            lblCategoria.Foreground = (Brush)bc.ConvertFrom("#707070");
            UMMenuPrincipal.IsEnabled = false;
            lblUM.Foreground = (Brush)bc.ConvertFrom("#707070");

        }

        /// <summary>
        /// Metodo del boton cerrar aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarApp_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("¿Desea Cerrar Aplicacion?","", MessageBoxButton.OKCancel,MessageBoxImage.Exclamation) == MessageBoxResult.OK)
            System.Windows.Application.Current.Shutdown();
        }

        /// <summary>
        /// Metodo del boton Cerar Secion del Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar Sesion de usuario?", "", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
            {
                

                WinWelcome2 login = new WinWelcome2();
                pnlContenedor.Children.Clear();
                _instancia = null;
                this.Close();
                login.ShowDialog();

            }
        }

        /// <summary>
        /// metodo para mostrar la ventana de ARTICULOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArticulosMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            UCArticulo oArticulos = UCArticulo.GetInstance();
            OpenInPanel(oArticulos);
        }

        /// <summary>
        /// metodo para mostrar la ventana CLIENTES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientesMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            WinClientes oClientes = new WinClientes();
            oClientes.ShowDialog();
        }

        /// <summary>
        /// metodo para mostrar la ventana de Categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoriaMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            UCcategoria categoria = UCcategoria.GetInstance();
            OpenInPanel(categoria);
        }

        private void UsuariosMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UMMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            UCum oUM = UCum.GetInstance();
            OpenInPanel(oUM);
        }

        private void FamiliaMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            UCfamilia oFamilia = UCfamilia.GetInstance();
            OpenInPanel(oFamilia);
        }

    }
}
