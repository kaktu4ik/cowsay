using System;

namespace cowsay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cowsay test --> ");
            string userText = Console.ReadLine();

            Console.Clear();

            cowsay(userText);
        }

        static void cowsay(string Print)
        {
            Console.Write("  ");
            for (int i = 0; i < Print.Length; i++)
            {
                Console.Write("_");
            }

            Console.WriteLine();
            Console.WriteLine("| " + Print + " |");

            Console.Write("  ");
            for (int i = 0; i < Print.Length; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();

            Console.WriteLine("          \\");
            Console.WriteLine("           \\");
            Console.WriteLine("             ^__^");
            Console.WriteLine("             (oo)\\_______");
            Console.WriteLine("             (__)\\       )\\/\\");
            Console.WriteLine("                 ||----w |");
            Console.WriteLine("                 ||     ||");
        }
    }
}