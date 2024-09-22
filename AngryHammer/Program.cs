using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AngryHammer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string language = null;

            for (int i = 0; i < args.Length; i++)
            {
                // Check for the "-lang" argument
                if (args[i] == "-lang")
                {
                    // Check if there is another argument after "-lang"
                    if (i + 1 < args.Length)
                    {
                        language = args[i + 1]; // Get the value following "-lang"
                    }
                    else
                    {
                        Console.WriteLine("Error: No value provided after '-lang'.");
                    }
                }
            }

            // Output the resolution value if provided
            if (language != null)
            {
                Console.WriteLine($"Lanuage: {language}");
            }
            else
            {
                Form form = new Form1("en");
                Application.Run(form);

                Console.WriteLine("No '-lang' argument provided.");
            }

            if (language == "ru")
            {
                Form rusform = new Form1("ru");
                Application.Run(rusform);
                return;
            }
            
        }
    }
}
