using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxer.Converters
{
    public class TreasureImageConverter : IValueConverter
    {
        public static TreasureImageConverter Instance = new();
        private Dictionary<string,object> _lookupValues = new();
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var name = value.GetType().Name.Replace("ViewModel", "");

            if (_lookupValues.ContainsKey(name))
                return _lookupValues[name];

            var asset = AssetLoader.Open(new Uri($"avares://Unboxer/Assets/{name}.jpg"));

            var image = new Bitmap(asset);

            _lookupValues[name] = image;

            return image;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
