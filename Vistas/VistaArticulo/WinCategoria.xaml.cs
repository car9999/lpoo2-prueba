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
    /// Lógica de interacción para WinCategoria.xaml
    /// </summary>
    public partial class WinCategoria : Window
    {
        public WinCategoria()
        {
            InitializeComponent();
        }

        private void btnVolverPrincipalCustom_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
