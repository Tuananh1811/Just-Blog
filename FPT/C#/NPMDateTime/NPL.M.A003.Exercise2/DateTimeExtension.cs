using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NPL.M.A003.Exercise2
{
    public static class DateTimeExtension
    {
        public static DateTime ToDateTime(this string stringDate)
        {
            var formats = new[] { "dd/MM/yyyy", "dd/MM/yyyy hh:mm:ss tt", "dd/MMM/yyyy" };
            for (int i = 0; i < formats.Length; i++)
            {
                bool isValidDate = DateTime.TryParseExact(stringDate, formats[i],
                                                 CultureInfo.InvariantCulture,
                                                 DateTimeStyles.AllowWhiteSpaces, out DateTime result);
                if (isValidDate) return result;
            }
            throw new ArgumentException($"{stringDate} is invalid format date");
        }

    }
}
