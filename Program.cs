using System;
using static System.Console;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vending Machine NRT";
            Console.ForegroundColor = ConsoleColor.Red;

            CenterText(@" 
                        
            ███▄▄▄▄      ▄████████     ███     
            ███▀▀▀██▄   ███    ███ ▀█████████▄ 
            ███   ███   ███    ███    ▀███▀▀██ 
            ███   ███  ▄███▄▄▄▄██▀     ███   ▀ 
            ███   ███ ▀▀███▀▀▀▀▀       ███     
            ███   ███ ▀███████████     ███     
            ███   ███   ███    ███     ███     
             ▀█   █▀    ███    ███    ▄████▀   
                        ███    ███             
           ");
              
            Console.ResetColor();
            
            WriteLine("Welcome to NRT Vending Machine! Select an option below:");
            Console.ReadKey(true);



            static void CenterText(string text)
            {
                int windowWidth = Console.WindowWidth;
                int padding = Math.Max(0, (windowWidth - text.Length) / 2);
                Console.WriteLine(new string(' ', padding) + text);

            }
        }
    }
}
