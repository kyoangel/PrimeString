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
            // empty string is prime
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            // one char string is prime
            if (s.Length < 2)
            {
                return true;
            }
            else
            {
                return RecursiveTestPrime(s.Substring(0, 1), s.Substring(1));
            }
        }

        /// <summary>
        /// separate whole string into two parts, Divisor:a and Dividend:b
        /// </summary>
        /// <param name="a">Divisor</param>
        /// <param name="b">Dividend</param>
        /// <returns></returns>
        private static bool RecursiveTestPrime(string a, string b)
        {
            if (b.Length < a.Length)
                return true;

            // b made by a means Not prime
            if (RecursiveIsBMadeByA(a, b))
            {
                return false;
            }
            else
            {
                // test longer 'a' and shorter 'b'
                return RecursiveTestPrime(a + b.Substring(0, 1), b.Substring(1));
            }
        }

        /// <summary>
        /// check if 'b' is just build by 'a' repeatedly
        /// </summary>
        /// <param name="a">Divisor</param>
        /// <param name="b">Dividend</param>
        /// <returns></returns>
        private static bool RecursiveIsBMadeByA(string a, string b)
        {
            // stop condition if b is shorter than a
            if (b.Length < a.Length)
                return false;
            // if length 'b' Divided by 'a' has Remainder
            if ((b.Length % a.Length) != 0)
                return false;

            if (b.Substring(0, a.Length).Equals(a))
            {
                // recursive end condition, make sure b is made by a
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
