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

namespace Vistas.user_control.mesa
{
    /// <summary>
    /// Interaction logic for UCmesas.xaml
    /// </summary>
    public partial class UCmesas : UserControl
    {
        private int cont = 0;
        private bool mesasCargadas = false;// bandera se usa para verificar si las mesas ya fueron cargadas en la ventana
        private static UCmesas _instancia;
        public UCmesas()
        {
            InitializeComponent();
        }

        public static UCmesas GetInstance()
        {

            if (_instancia == null)
                _instancia = new UCmesas();

            return _instancia;
        }

        //private void btnVolverPrincipal_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}

        /// <summary>
        /// quita una mesa de la ventana mesas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarMesa_Click(object sender, RoutedEventArgs e)
        {
            cont--;
            wrpArea.Children.RemoveAt(cont);
        }

        /// <summary>
        /// agrega una nueva mesa a la ventana 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarMesa_Click(object sender, RoutedEventArgs e)
        {
            agregarNuevaMesa();
        }

        /// <summary>
        /// genera las mesas, mediante un objeto button, de manera dinamica
        /// </summary>
        private void agregarNuevaMesa()
        {
            cont++;
            string nombre = "btnMesa" + cont.ToString();
            Button btnMesa = new Button();
            btnMesa.Content = "Mesa " + cont.ToString();
            btnMesa.Name = "btnMesa" + cont.ToString();
            btnMesa.Width = 80;
            btnMesa.Height = 40;
            btnMesa.Margin = new Thickness(20);
            btnMesa.Background = Brushes.Green;
            btnMesa.Foreground = Brushes.White;
            btnMesa.Click += mesa_Click;
            if (cont == 15 || cont == 17)
                btnMesa.Background = Brushes.Red;
            else
                btnMesa.Background = Brushes.Green;
            wrpArea.Children.Add(btnMesa);
        }

        /// <summary>
        /// metodo que verifica el estado de una mesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mesa_Click(object sender, RoutedEventArgs e)
        {
            Button btnMesa = sender as Button;
            if (btnMesa.Background == Brushes.Green)
            {
                MessageBox.Show(btnMesa.Content + ": LIBRE");
            }
            else
                MessageBox.Show(btnMesa.Content + ": OCUPADA");
        }

        /// <summary>
        /// verifica la bandera mesasCargadas en falso, y carga las mesas en la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdMesas_Loaded(object sender, RoutedEventArgs e)
        {
            if (mesasCargadas == false)
            {
                for (int i = 0; i < 20; i++)
                {
                    agregarNuevaMesa();
                }
                mesasCargadas = true;
            }
        }

    }
}
