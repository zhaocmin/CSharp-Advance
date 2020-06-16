using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ToDoApp.Converters
{
    public class DisplayMultiConverters : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null)
            {
                if (values.Length == 2)
                {
                    bool display = false;
                    if (bool.TryParse(values[0].ToString(), out bool result))
                    {
                        display = result;
                    }

                    var title = values[1].ToString();

                    if (title != "My Day" && !display)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        string time = string.Format("{0:M}", DateTime.Now);

                        string[] weeks = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

                        string week = weeks[System.Convert.ToInt32(DateTime.Now.DayOfWeek)];
                        return $"{time},{week}";
                    }
                }
            }
            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
