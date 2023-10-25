using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace PlaginRadioBC.Helpers.Converters
{
    public class TextToMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = value as string;
            if (string.IsNullOrEmpty(text))
                return new Thickness(0, 0, 0, 0);

            int marginValue = text.Length * 10;

            return new Thickness(0, 0, marginValue, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
