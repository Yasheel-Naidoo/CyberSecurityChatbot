/*
 * AUTHOR: Yasheel
 * DESCRIPTION: The Visuals and Animations for ShieldBot.
 */
using System;
using System.Threading;

namespace Chatbot
{
    public static class Utils
    {
        // Task 6: Typing effect for a "conversational" feel
        public static void TypeLine(string text, ConsoleColor color = ConsoleColor.White, int speed = 25)
        {
            if (string.IsNullOrEmpty(text)) return;
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        // IMPROVEMENT: Simulated thinking animation
        public static void SimulateThinking()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[ShieldBot is thinking]");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine("\n");
            Console.ResetColor();
        }

        // Task 6: Enhanced UI Headers
        public static void PrintHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔" + new string('═', 58) + "╗");
            Console.WriteLine($"║{CenterText(title, 58)}║");
            Console.WriteLine("╚" + new string('═', 58) + "╝");
            Console.ResetColor();
        }

        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('─', 60));
            Console.ResetColor();
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[!] ERROR: {message}");
            Console.ResetColor();
        }

        // Helper to center text in the UI boxes
        private static string CenterText(string text, int width)
        {
            if (string.IsNullOrEmpty(text)) return new string(' ', width);
            int padding = (width - text.Length) / 2;
            return text.PadLeft(padding + text.Length).PadRight(width);
        }
    }
}