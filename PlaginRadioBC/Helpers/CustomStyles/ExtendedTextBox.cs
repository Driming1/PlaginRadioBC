using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace PlaginRadioBC.Helpers.CustomStyles
{
    public class ExtendedTextBox : TextBox
    {
        static ExtendedTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtendedTextBox), new FrameworkPropertyMetadata(typeof(TextBox)));
        }

        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.Register("PlaceholderText", typeof(string), typeof(ExtendedTextBox), new PropertyMetadata(string.Empty));

        public string PlaceholderText
        {
            get { return (string)GetValue(PlaceholderTextProperty); }
            set { SetValue(PlaceholderTextProperty, value); }
        }
    }
}
