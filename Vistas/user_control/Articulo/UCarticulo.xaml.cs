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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClasesBase;
using DataWorker;
namespace Vistas.user_control.Articulo
{
    /// <summary>
    /// Interaction logic for UCArticulo.xaml
    /// </summary>
    public partial class UCArticulo : UserControl
    {
        public static UCArticulo _instance;
        public UCArticulo()
        {
            InitializeComponent();
        }

        public static UCArticulo GetInstance()
        {
            if (_instance == null)
                _instance = new UCArticulo();
            return _instance;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || cmbFamilia.Text == "Seleccione .." || cmbUnidadMedida.Text == "Seleccione ..")
            {
                MessageBox.Show("No puede registrar campo vacios ni campos sin seleccionar", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                ClasesBase.Articulo articulo = new ClasesBase.Articulo();
                MessageBoxResult result;
                result = MessageBox.Show("Guardar los campos?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.OK)
                {
                    crearArticulo(articulo);
                    MessageBox.Show(encadenarDatosArticulo(articulo), "ARTICULO GUARDADO", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiarForm();
                }
            }
        }

        private void crearArticulo(ClasesBase.Articulo articulo)
        {
            articulo.Art_Descrip = txtDescripcion.Text;
            articulo.Fam_Id = cmbFamilia.Text;
            articulo.UM_Id1 = cmbUnidadMedida.Text;
            articulo.Art_Precio = Convert.ToDecimal(txtPrecio.Text);
            articulo.Art_ManejaStock = rbnSi.IsChecked.Value;
        }

        private string encadenarDatosArticulo(ClasesBase.Articulo articulo)
        {
            string sCadenaDatosArticulo = "DATOS: \n\n" +
                                              "Descripcion: " + articulo.Art_Descrip + "\n" +
                                              "Familia: " + articulo.Fam_Id + "\n" +
                                              "Unidad de Medida: " + articulo.UM_Id1 + "\n" +
                                              "Precio: " + articulo.Art_Precio + "\n" +
                                              "Stock: " + definirStock(articulo);

            return sCadenaDatosArticulo;
        }

        private string definirStock(ClasesBase.Articulo articulo)
        {
            string cadena;
            if (articulo.Art_ManejaStock == true)
                cadena = "Pesee Stock";
            else
                cadena = "No Posee Stock";
            return cadena;
        }


        private void limpiarForm()
        {
            txtDescripcion.Text = "";
            cmbFamilia.SelectedIndex = -1;
            cmbUnidadMedida.SelectedIndex = -1;
            txtPrecio.Text = "";
            rbnSi.IsChecked = false;
        }

       

    }
}
