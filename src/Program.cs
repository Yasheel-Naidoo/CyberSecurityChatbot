/*
 * AUTHOR: Yasheel
 * DESCRIPTION: The Interface for ShieldBot.
 */
using System;

namespace Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 6: Visual branding
            Console.Title = "ShieldBot | Cybersecurity Assistant";

            // Task 7: Clear class structure
            Chatbot bot = new Chatbot();
            bot.Launch();
        }
    }
}