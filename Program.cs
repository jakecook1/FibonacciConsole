namespace FibonacciConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequence;
            int.TryParse(args.Length > 0 ? args[0] : "0", out sequence);

            new Fibonacci(sequence).GetSequenceNumber();
        }
    }
}
