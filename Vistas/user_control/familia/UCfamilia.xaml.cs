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
namespace Vistas.user_control.familia
{
    /// <summary>
    /// Interaction logic for UCfamilia.xaml
    /// </summary>
    public partial class UCfamilia : UserControl
    {
        private static UCfamilia _instancia;
        public UCfamilia()
        {
            InitializeComponent();
        }

        public static UCfamilia GetInstance()
        {

            if (_instancia == null)
                _instancia = new UCfamilia();

            return _instancia;
        }
        /// <summary>
        /// metodo del evento click del boton volver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        /// <summary>
        /// metodo del evento click del boton agregar un tipo de familia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescripFLIA.Text.Trim() == "")
            {
                MessageBox.Show("No se puede registrar sin datos", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Familia oFlia = new Familia();
                MessageBoxResult result;
                result = MessageBox.Show("Guardar dato?", "", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.OK)
                {
                    crearFLIA(oFlia);
                    MessageBox.Show(mostrarDato(oFlia), "TIPO DE FAMILIA", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiarCampos();
                }
            }
        }

        /// <summary>
        /// asigna el valor introducido al objeto FLIA
        /// </summary>
        /// <param name="um"></param>
        private void crearFLIA(Familia fl)
        {
            fl.Fam_Descrip = txtDescripFLIA.Text;
        }


        /// <summary>
        /// Se arma un mensaje para el messagebox
        /// </summary>
        /// <param name="um"></param>
        /// <returns></returns>
        private string mostrarDato(Familia fl)
        {
            return "Dato: \n\n" + "Tipo: " + txtDescripFLIA.Text;
        }


        /// <summary>
        /// limpia el campo llenado
        /// </summary>
        private void limpiarCampos()
        {
            txtDescripFLIA.Text = "";
        }


    }
}
