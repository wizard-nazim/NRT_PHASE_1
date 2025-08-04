using System;
using static System.Console;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vending Machine NRT";
        
            String[] Snacks = {"MicroChips","RAM-en Noodles", "Mama J's Donuts"};
            String[] Drinks = {"Energy++","PSU-Drink","Stoney" };
            Double[] SPrices = { 2, 20.00, 5.00 };
            Double[] DPrices = { 17.50, 15.00, 20.00 };

            int[] SStock = { 3, 3, 3 };
            int[] DStock = { 3, 3, 3 };



            

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
            Console.Write($@"
                                                                               
                                                       
        ┌───────────────────────────────────────────────────┐                         
        │ Balance:                                          │                         
        │                                                   │                         
        └───────────────────────────────────────────────────┘                         
        ┌──────────────────────────┬────────────────────────┐                         
        │Snacks:                   │VERY-COOL-Drinks:       │                         
        ├──────────────────────────┼────────────────────────┤                         
        │                          │                        │                         
        │(A){Snacks[0]}            │(D){Drinks[0]}          │                         
        │                          │                        │                         
        │Price:R{SPrices[0]}       │Price:R{DPrices[0]}     │                         
        │Stock:{SStock[0]}         │Stock:{DStock[0]}       │                         
        ├──────────────────────────┼────────────────────────┤                         
        │                          │                        │                         
        │(B){Snacks[1]}            │(E){Drinks[1]}          │                         
        │                          │                        │                         
        │Price:R{SPrices[1]}       │Price:R{DPrices[1]}     │                         
        │Stock:{SStock[1]}         │Stock:{DStock[1]}       │                         
        ├──────────────────────────┼────────────────────────┤                         
        │                          │                        │                         
        │(C){Snacks[2]}            │(F){Drinks[2]}          │                         
        │                          │                        │                         
        │Price:R{SPrices[2]}       │Price:R{DPrices[2]}     │                         
        │Stock:{SStock[2]}         │Stock:{DStock[2]}       │                         
        ├──────────────────────────┼────────────────────────┤                         
        │ 1:Deposit                │xxxxxxxxxxxxxxxxxxxxxxxx│                         
        │ 2:Withdraw               │xx┌──────────────────┐xx│                         
        │ 3:Cart                   │xx│                  │xx│                         
        │ 4:Exit                   │xx│                  │xx│                         
        │                          │xx│                  │xx│                         
        │                          │xx│                  │xx│                         
        │                          │xx└──────────────────┘xx│                         
        │                          │xxxxxxxxxxxxxxxxxxxxxxxx│                         
        └──────────────────────────┴────────────────────────┘                         
                                                                                  
                                                                                  
                                                                                  
                                                                                  
                                                                     

");







































            Console.ReadKey();



            static void CenterText(string text)
            {
                int windowWidth = Console.WindowWidth;
                int padding = Math.Max(0, (windowWidth - text.Length) / 2);
                Console.WriteLine(new string(' ', padding) + text);

            }
        }
    }
}
