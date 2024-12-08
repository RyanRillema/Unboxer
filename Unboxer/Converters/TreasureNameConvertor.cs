using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.ViewModels.Tresures;

namespace Unboxer.Converters
{
    public class TreasureNameConverter : IValueConverter
    {
        public static TreasureNameConverter Instance = new TreasureNameConverter();
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
           return value.GetType().Name.Replace("ViewModel", "");           
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
