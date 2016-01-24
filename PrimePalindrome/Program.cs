using System.Globalization;
using System.IO;

namespace PrimePalindrome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Program
    {
        public static void Main(String[] args)
        {
            for (var i = 999; i >= 1; i--)
            {
                if (IsPalindrome(i.ToString(CultureInfo.InvariantCulture)) && IsPrime(i))
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }

        public static Boolean IsPrime(Int32 num)
        {
            var boundary = Math.Floor(Math.Sqrt(num));

            switch (num)
            {
                case 1:
                    return false;
                case 2:
                    return true;
            }

            for (var i = 2; i <= boundary; ++i)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        public static Boolean IsPalindrome(String text)
        {
            return String.CompareOrdinal(text, Reverse(text)) == 0;
        }

        public static String Reverse(String s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }
    }
}
