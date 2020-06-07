using System;
using System.Globalization;
using Xamarin.Forms;

namespace Comic.Converters
{
    public class TestConverter : IValueConverter
    {
        public TestConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.IsNullOrEmpty("");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
