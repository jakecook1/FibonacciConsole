using System;
using FibonacciConsole.Helpers;

namespace FibonacciConsole
{
    public class Fibonacci
    {
        private readonly int _sequence;

        public Fibonacci(int sequence)
        {
            _sequence = sequence;
        }

        public void GetSequenceNumber()
        {
            //
            // Examples of different ways to calculate the Fibonacci sequence
            //
            "\nThe Fibonacci number at the \"{0}th\" position is...\n".ToConsole(_sequence);

            // Using a "for loop" an example of dynamic programming
            ByForLoop(_sequence);

            // Using "recursion" an example using memoization
            Recursive(1, 1, 1, _sequence);

            // Using "Closed form formula" an example using the golden ratio
            GoldenRation(_sequence);

            "\nProgram Finished...\n".ToConsole();
        }

        private void ByForLoop(int number)
        {
            var prev = 0;
            var next = 1;

            for (var i = 1; i <= number; i++)
            {
                if (i == number)
                    break;

                var newNum = prev + next;
                prev = next;
                next = newNum;
            }

            "\tUsing \"For Loop\": {0}".ToConsole(next);
        }

        public void Recursive(int a, int b, int counter, int number)
        {
            if (counter >= number)
                "\tUsing \"Recursion\": {0}".ToConsole(a);

            if (counter < number)
                Recursive(b, a + b, counter + 1, number);
        }

        private void GoldenRation(int number)
        {
            // Phi is the 21st letter of the Greek Alphabet used to represent the golden ratio
            var sqrt5 = Math.Sqrt(5);
            var phi = (sqrt5 + 1) / 2;
            var fibNum = (int)(Math.Pow(phi, number) / sqrt5 + 0.5);
            "\tUsing \"Golden Ration\" {0}".ToConsole(fibNum);
        }
    }
}