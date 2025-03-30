using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.src
{
    public class Utils
    {
        public static bool ConverterData(string dataString, string formato, out DateTime data)
        {
            return DateTime.TryParseExact(dataString, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
        }
    }
}
