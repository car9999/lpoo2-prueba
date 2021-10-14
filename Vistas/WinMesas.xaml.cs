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

namespace Vistas
{
    /// <summary>
    /// Interaction logic for WinMesas.xaml
    /// </summary>
    public partial class WinMesas : Window
    {
        private int cont = 0;

        public WinMesas()
        {
            InitializeComponent();
        }

        private void btnVolverPrincipal_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnQuitarMesa_Click(object sender, RoutedEventArgs e)
        {
            cont--;
            wrpArea.Children.RemoveAt(cont);
        }

        private void btnAgregarMesa_Click(object sender, RoutedEventArgs e)
        {
            agregarNuevaMesa();
        }

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                agregarNuevaMesa();
            }
        }
        
    }
}
