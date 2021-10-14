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
    /// Interaction logic for WinFamilias.xaml
    /// </summary>
    public partial class WinFamilias : Window
    {
        public WinFamilias()
        {
            InitializeComponent();
        }


        private void btnVolverPrincipal_Click(object sender, RoutedEventArgs e)
        {
            WinPrincipal main = new WinPrincipal();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("No puede tener campos vacios", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }else
            {
                Familia oFamilia = new Familia();
                MessageBoxResult result;
                result = MessageBox.Show("Guardar los campos?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.OK)
                {
                    crearFamilia(oFamilia);
                    MessageBox.Show(encadenarDatosFamilia(oFamilia), "FAMILIA GUARDADA", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiarForm();
                }
            }
        }

        private void crearFamilia(Familia familia)
        {
            familia.Fam_Descrip = txtDescripcion.Text;
        }

        private void limpiarForm()
        {
            txtDescripcion.Text="";
        }

        private string encadenarDatosFamilia(Familia familia)
        {
            string sCadenaDatosArticulo = "DATOS: \n\n" +
                                              "Descripcion: " + familia.Fam_Descrip + "\n";
            return sCadenaDatosArticulo;
        }
    }
    
}
