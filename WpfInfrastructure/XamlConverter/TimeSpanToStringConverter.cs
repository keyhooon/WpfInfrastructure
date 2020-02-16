using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace WpfInfrastructure.XamlConverter
{
    public class TimeSpanToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var sb = new StringBuilder();
            if (value == null)
                return "Not Estimated";
            if (!(value is TimeSpan t)) return "Not Estimated";
            var days = (int)Math.Floor( t.TotalDays);
            if (days != 0)
                sb.AppendFormat("{0} Day(s)", days);
            if (t.Hours != 0)
                if (t.Minutes != 0)
                    sb.AppendFormat("{0}:{1} hour(s)", t.Hours, t.Minutes);
                else
                    sb.AppendFormat("{0} hour(s)", t.Hours);
            return sb.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
