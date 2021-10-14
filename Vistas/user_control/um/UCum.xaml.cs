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
namespace Vistas.user_control.um
{
    /// <summary>
    /// Interaction logic for UCum.xaml
    /// </summary>
    public partial class UCum : UserControl
    {
        private static UCum _instancia;
        public UCum()
        {
            InitializeComponent();
        }

        public static UCum GetInstance()
        {

            if (_instancia == null)
                _instancia = new UCum();

            return _instancia;
        }

        /// <summary>
        /// metodo del evento click del boton volver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnVolverPrincipal_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}


        /// <summary>
        /// metodo del evento click del boton agregar unidad de medida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescrip.Text.Trim() == "" || txtAbrev.Text.Trim() == "")
            {
                MessageBox.Show("No puede registrar campo vacios ni campos sin seleccionar", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Unidad_Medida oUM = new Unidad_Medida();
                MessageBoxResult result;
                result = MessageBox.Show("Guardar los campos?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.OK)
                {
                    crearUM(oUM);
                    MessageBox.Show(encadenarDatosUM(oUM), "ARTICULO GUARDADO", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiarCampos();
                }

            }
        }

        /// <summary>
        /// asigna los valores de las propiedades textbox al objeto UM
        /// </summary>
        /// <param name="um"></param>
        private void crearUM(Unidad_Medida um)
        {
            um.UM_Abrev1 = txtAbrev.Text;
            um.UM_Descrip1 = txtDescrip.Text;
        }


        /// <summary>
        /// Encadena los campos en un solo string para mostrarlos en messagebox
        /// </summary>
        /// <param name="um"></param>
        /// <returns></returns>
        private string encadenarDatosUM(Unidad_Medida um)
        {
            return "Datos: \n\n" + "Descripcion: " + um.UM_Descrip1 + "\n" + "Abreviado: " + um.UM_Abrev1;
        }


        /// <summary>
        /// limpia los campos del formulario de ventana Unidades de Medida
        /// </summary>
        private void limpiarCampos()
        {
            txtDescrip.Text = "";
            txtAbrev.Text = "";
            cmbSeleccionar.SelectedIndex = -1;
        }
    }
}
