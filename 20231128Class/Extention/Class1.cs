using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128Class.Extention
{

    internal static class Class1
    {
        static int number { get; set; }

        public static bool IsPositive(this int num)
        {
            return num >= 0;
        }



        public static bool HasSpace(this string text)
        {
            return text.Contains(" ");
        }
    }
}
