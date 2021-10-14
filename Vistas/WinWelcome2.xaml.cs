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
using DataWorker;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for WinWelcome2.xaml
    /// </summary>
    public partial class WinWelcome2 : Window
    {
       
        public WinWelcome2()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            String sUsuario = login.Usuario;
            String sContraseña = login.Contraseña;
            if (sUsuario == "" || sContraseña == "")
                MessageBox.Show("Debe completar todos los campos", "", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                Usuario userLog = null;
                userLog = UsuarioDataworker.loginUsuario(sUsuario, sContraseña);
               if (userLog!=null)
                {
                     TrabajarUsuario.usuario_logueado = userLog;
                     mostrar_principal();
                 }else
                   MessageBox.Show("Usuario o contraseña incorrectos", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void mostrar_principal()
        {
            WinPrincipal abrir = WinPrincipal.GetInstancia();
            abrir.Show();
            this.Close();
        }
    }
}
