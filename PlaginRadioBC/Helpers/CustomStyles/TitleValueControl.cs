using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace PlaginRadioBC.Helpers.CustomStyles
{
    public class TitleValueControl : Control
    {
        static TitleValueControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleValueControl), new FrameworkPropertyMetadata(typeof(TitleValueControl)));
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(TitleValueControl), new PropertyMetadata(string.Empty));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(TitleValueControl), new PropertyMetadata(string.Empty));

        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
    }
}
