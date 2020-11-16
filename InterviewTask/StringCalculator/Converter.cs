using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public static class Converter
    {
        public static int Add(string number)
        {
            if (!int.TryParse(number, out int result))
                return 0;
            return result;
        }
    }
}
