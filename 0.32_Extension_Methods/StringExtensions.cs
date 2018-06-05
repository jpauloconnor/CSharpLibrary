using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._32_Extension_Methods
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a list of strings to title case
        /// By adding 'this' in the parameter we can make it a string method....
        /// </summary>
        public static string ConvertToTitleCase(this string source)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(source);
        }
    }
}
