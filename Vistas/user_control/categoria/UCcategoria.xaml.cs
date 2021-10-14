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

namespace Vistas.user_control.categoria
{
    /// <summary>
    /// Interaction logic for UCcategoria.xaml
    /// </summary>
    public partial class UCcategoria : UserControl
    {
        private static UCcategoria _instancia;
        public UCcategoria()
        {
            InitializeComponent();
        }

        public static UCcategoria GetInstance()
        {

            if (_instancia == null)
                _instancia = new UCcategoria();

            return _instancia;
        }
    }
}
