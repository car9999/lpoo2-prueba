using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace Vistas.ValueConverter
{
    public class ConversorDeEstados : IValueConverter
    {
        /// <summary>
        /// Recibe un object que representa el estado de una mesa y devuelve el tipo de dato Brush
        /// </summary>
        /// <param name="value"></param> 
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var converter = new BrushConverter();
            if (value != null)
            {
                switch (value.ToString())
                {
                    case "Libre": return (Brush)converter.ConvertFrom("#42AD43");
                    case "Reservada": return (Brush)converter.ConvertFrom("#E2A13D");
                    case "Ocupada": return (Brush)converter.ConvertFrom("#FF0000");
                    case "Pidiendo": return (Brush)converter.ConvertFrom("#9A5DFF");
                    case "En Espera": return (Brush)converter.ConvertFrom("#B5FFC9");
                    case "Servidos": return (Brush)converter.ConvertFrom("#FF9878");
                    case "Esperando Cuenta": return (Brush)converter.ConvertFrom("#5CA9FF");
                    case "Pagado": return (Brush)converter.ConvertFrom("#95AB55");

                    default: return Brushes.Gray;
                }
            }
            else
            {
                return Brushes.White;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
