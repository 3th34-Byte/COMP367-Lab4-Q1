using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionsLib
{
    public static class StringExtensions
    {
        public static bool StartsWithUppercase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return char.IsUpper(input[0]);
        }
    }
}