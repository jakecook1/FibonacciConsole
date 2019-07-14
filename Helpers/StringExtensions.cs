using System;

namespace FibonacciConsole.Helpers
{
    public static class StringExtensions
    {
        public static void ToConsole(this string text, params object[] values)
        {
            Console.WriteLine(text, values);
        }
    }
}