// ShieldBot Version 1.0 - Optimized Knowledge Base
/*
 * AUTHOR: Yasheel
 * DESCRIPTION: The core logic for ShieldBot.
 */

using System;
using System.IO;
using System.Media;



namespace Chatbot
{
    public class Chatbot
    {
        public string UserName { get; set; } = "Citizen";

        // Task 4: Cybersecurity Knowledge Base
        private readonly string[] _keywords = { "phishing", "password", "browsing", "malware", "mfa", "social media", "wifi" };
        private readonly string[] _tips = {
            "PHISHING: Scammers use fake emails to steal login details. Always verify the sender before clicking!",
            "PASSWORDS: Use a long 'passphrase' with symbols. A password manager is the safest way to store them.",
            "SAFE BROWSING: Ensure websites use 'HTTPS' (padlock icon). Avoid entering data on non-secure sites.",
            "MALWARE: Keep your software updated! Updates contain critical patches against viruses and spyware.",
            "MFA: Multi-Factor Authentication adds a second layer of security, like an SMS code, to your password.",
            "SOCIAL MEDIA: Set your profiles to private and be wary of requests from people you don't know.",
            "WIFI: Public Wi-Fi is unencrypted. Use a VPN if you must access sensitive accounts away from home."
        };

        // Relative paths for universal compatibility on any device
        private readonly string _audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "greeting.wav");
        private readonly string _logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "logo.txt");

        public void Launch()
        {
            PlayVoice();
            DisplayInterface();
            GetUserInfo();
            ChatLoop();
        }

        private void PlayVoice()
        {
            try
            {
                if (File.Exists(_audioPath))
                {
                    using (SoundPlayer player = new SoundPlayer(_audioPath))
                    {
                        player.Load();
                        player.PlaySync();
                    }
                }
            }
            catch { /* Fail silently to prevent crashes on non-audio devices */ }
        }

        private void DisplayInterface()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (File.Exists(_logoPath))
            {
                Console.WriteLine(File.ReadAllText(_logoPath));
            }

            Utils.PrintHeader("ShieldBot: Cybersecurity Awareness v1.0");
        }

        private void GetUserInfo()
        {
            Utils.TypeLine("[ShieldBot]: Protocol initialized. Firewall Active.", ConsoleColor.DarkGray);

            // Your specific requirement: Keep [Bot] only for the name request
            Console.Write("\n[Bot]: Hi! I am ShieldBot. I'd love to know your name: ");
            string? input = Console.ReadLine();
            UserName = string.IsNullOrWhiteSpace(input) ? "Citizen" : input;

            // Everything else changed to [ShieldBot]
            Utils.TypeLine($"\n[ShieldBot]: Wonderful to meet you, {UserName}!", ConsoleColor.Yellow);

            Utils.PrintDivider();
            ShowHelp();
        }

        // Helper method to display prompts with ShieldBot branding
        private void ShowHelp()
        {
            Utils.TypeLine("[ShieldBot]: Here is what I can help you with:", ConsoleColor.Cyan);
            Utils.TypeLine(" ➔ Ask about 'Phishing', 'Passwords', or 'Malware'", ConsoleColor.Yellow, 10);
            Utils.TypeLine(" ➔ Ask 'How are you?' or 'What is your purpose?'", ConsoleColor.Yellow, 10);
            Utils.TypeLine(" ➔ Type 'What else' to see more safety topics", ConsoleColor.Yellow, 10);
            Utils.TypeLine(" ➔ Type 'Exit' to leave", ConsoleColor.Yellow, 10);
            Utils.PrintDivider();
        }

        private void ChatLoop()
        {
            bool active = true;
            while (active)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n[{UserName}] > ");
                string query = Console.ReadLine()?.ToLower().Trim() ?? "";

                if (string.IsNullOrEmpty(query))
                {
                    Utils.PrintError("[ShieldBot]: It looks like you didn't type anything. What's on your mind?");
                    continue;
                }

                Utils.SimulateThinking();

                if (query == "help" || query.Contains("what can you do") || query.Contains("what can i ask"))
                {
                    ShowHelp();
                }
                else if (query.Contains("what else"))
                {
                    Utils.TypeLine("[ShieldBot]: I also have expert advice on these specific topics:", ConsoleColor.Cyan);
                    for (int i = 3; i < _keywords.Length; i++)
                        Utils.TypeLine($" ➔ {_keywords[i].ToUpper()}", ConsoleColor.Yellow, 10);
                }
                else if (query.Contains("how are you"))
                {
                    Utils.TypeLine($"[ShieldBot]: I'm doing great and ready to assist you, {UserName}!", ConsoleColor.Green);
                }
                else if (query.Contains("purpose"))
                {
                    Utils.TypeLine("[ShieldBot]: My mission is to protect South African citizens through cybersecurity education.", ConsoleColor.Green);
                }
                else if (query.Contains("exit") || query.Contains("bye"))
                {
                    Utils.TypeLine($"[ShieldBot]: It was nice chatting. Stay safe, {UserName}!", ConsoleColor.Yellow);
                    active = false;
                }
                else
                {
                    bool foundTip = false;
                    for (int i = 0; i < _keywords.Length; i++)
                    {
                        if (query.Contains(_keywords[i]))
                        {
                            Utils.TypeLine($"[ShieldBot]: {_tips[i]}", ConsoleColor.Green);
                            foundTip = true;
                            break;
                        }
                    }

                    if (!foundTip)
                    {
                        Utils.PrintError("[ShieldBot]: I'm not sure about that yet. Try typing 'help' to see my commands.");
                    }
                }
                Utils.PrintDivider();
            }
        }
    }
}