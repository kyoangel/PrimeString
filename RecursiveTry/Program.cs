using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTry
{
    public class Kata
    {
        public static void Main(string[] args)
        {
            string testStr = "";

            if (args.Length !=0)
                testStr = args[0];

            Console.WriteLine("your input: \"" + testStr + "\"");
            Console.WriteLine(PrimeString(testStr) ? "Is a Prime String":"Is \"NOT\" a Prime String");

            Console.ReadLine();

        }

        public static bool PrimeString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (s.Length < 2)
            {
                return true;
            }
            else
            {
                return RecursiveIsPrime(s.Substring(0, 1), s.Substring(1));
            }
        }

        private static bool RecursiveIsPrime(string a, string b)
        {
            if (b.Length < a.Length)
                return true;

            if (RecursiveIsBMadeByA(a, b))
            {
                return false;
            }
            else
            {
                return RecursiveIsPrime(a + b.Substring(0, 1), b.Substring(1));
            }
        }

        private static bool RecursiveIsBMadeByA(string a, string b)
        {
            if (b.Length < a.Length)
                return false;
            if ((b.Length % a.Length) != 0)
                return false;

            if (b.Substring(0, a.Length).Equals(a))
            {
                if (b.Length == a.Length)
                    return true;
                return RecursiveIsBMadeByA(a, b.Substring(a.Length));
            }
            else
            {
                return false;
            }
        }
    }
}
