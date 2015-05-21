namespace ConsoleSample
{
    using System;

    public static class Program
    {
        private static Random randomValue = new Random();

        static void Main(string[] args)
        {
            var quit = false;

            while (quit == false)
            {
                Console.Write("Ask a question: ");
                var message = Console.ReadLine();
                
                if (string.Equals("quit", message, StringComparison.OrdinalIgnoreCase))
                {
                    quit = true;
                }

                Console.WriteLine(Response(message));
            }
        }

        private static string Response(string inputmessage)
        {
            var answer = randomValue.Next(0, 2) == 0 ? "yes" : "no";

            return string.Format("Hmm, '{0}'. I guess, {1}", inputmessage, answer);
        }
    }
}
