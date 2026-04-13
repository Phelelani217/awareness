using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace awareness
{
    internal class Chatbot
    {
    
            private readonly string asciiBot = @"
 ________________
|CYBER AWARENESS |
| _______________|
";

            public void PlayWelcomeSound()
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(awareness.Properties.Resources.voice);
                    player.Play();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"(Audio failed to play: {ex.Message})");
                }
            }

            public void GreetUser()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("CYBERSECURITY AWARENESS");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("------------------------");
                Console.ResetColor();
            }

            public string GetUserName()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("What is your name? : ");
                Console.ResetColor();
                return Console.ReadLine();
            }

            public void ShowAsciiBot()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(asciiBot);
                Console.ResetColor();
            }

            public void ShowWelcomeMessage(string name)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Hello {name} WELCOME TO THE CYBERSECURITY AWARENESS BOT!", 20);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("How are you?: ");
                Console.ResetColor();
                Console.ReadLine(); // Just for interaction
            }

            public void DisplayInvalidOptionMessage()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("I didn't quite understand that. Please rephrase.", 20);
                Console.ResetColor();
            }

            public void DisplayGoodbyeMessage()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Goodbye", 20);
                Console.ResetColor();
            }

            public void TypeText(string text, int delay)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    Thread.Sleep(delay);
                }
                Console.WriteLine("\n");
            }
        }
    }

