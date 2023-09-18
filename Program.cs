using System;
using System.Collections.Generic;

namespace inf04
{
    internal static class Program
    {
        public static int Nwd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        public static void Main(string[] args)
        {
            var a = int.Prase(Console.ReadLine());
            var b = int.Prase(Console.ReadLine());

            Console.WriteLine(Nwd(a, b));
        }
    }
}