﻿namespace AppPropina.Converters
{
       using System;
        using System.Collections.Generic;
        using System.Globalization;
        using System.Text;
        using Xamarin.Forms;

        public class DecimalConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var valor = (double)value;
                return valor.ToString("C");
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var valor = (string)value;
                return valor.Remove(0);
            }
        }
    }
