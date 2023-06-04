using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Buz.Banking.UI.Wpf.Common
{
    public static class Converters
    {
        public static readonly IValueConverter NotNullToVisible = new NotNullToVisibleConverter();
    }

    public class NotNullToVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
