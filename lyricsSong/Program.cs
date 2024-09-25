using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        PrintLyrics();//method invocation
    }

    public static void PrintLyrics()
    {
        // Define the lyrics with character delay for each line
        (string line, double charDelay)[] lines = new (string, double)[]
        {
           ("If the world was ending", 0.10),
        ("I'd wanna be next to you", 0.095),
        ("If the party was over", 0.12),
        ("And our time on Earth was through", 0.11),
        ("I'd wanna hold you just for a while",0.11),
        ("And die with a smile",0.12),
        ("If the world was ending",0.110),
        ("Id wanna be next to you",0.15),
        ("If the world was ending",0.25),
        ("Id wanna be next to you",0.50)
        };

        // Define the delay after each line
        double[] delays = [ 0.13, 0.15, 0.5, 2 ];

        // Print each line with character delay and overall line delay
        for (int i = 0; i < lines.Length; i++)
        {
            var (line, charDelay) = lines[i];

            // Print each character with delay
            foreach (char c in line)
            {
                Console.Write(c);
                Thread.Sleep((int)(charDelay * 1000)); // Convert seconds to milliseconds
            }

            // Add line break after each line
            Console.WriteLine();

            // Wait for the delay after each line
            Thread.Sleep((int)(delays[i] * 1000)); // Convert seconds to milliseconds
        }
    }
}
