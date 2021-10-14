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
    /// Interaction logic for WinWelcome.xaml
    /// </summary>
    public partial class WinWelcome : Window
    {
        public WinWelcome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// boton aceptar del login
        /// prueba
        /// prueba2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            Usuario[] lista = new Usuario[3];
            lista[0] = new Usuario("admin", "asdf", 1 );
            lista[1] = new Usuario("mozo", "asdf", 2);
            lista[2] = new Usuario("vendedor", "asdf", 3);

            bool encontrado = false;

            if (txtUsuario.Text == "" || txtContraseña.Password == "")
                MessageBox.Show("tiene campos vacios", "", MessageBoxButton.OK, MessageBoxImage.Error);
            else 
            {
                for (int i = 0; i < lista.Length; i++)
                    if(txtContraseña.Password == lista[i].Usu_Contraseña)
                        if (txtUsuario.Text == lista[i].Usu_NombreUsuario)
                        {
                            encontrado = true;
                            TrabajarUsuario.usuario_logueado = lista[i];
                            mostrar_principal();
                        }
                if (encontrado == false)
                    MessageBox.Show("Usuario o contraseña incorrectos", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
        }

        /// <summary>
        /// metodo que muestra la ventana principal de la aplicacion
        /// </summary>
        private void mostrar_principal()
        {
            WinPrincipal main = new WinPrincipal();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
