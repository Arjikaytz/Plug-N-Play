using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PLUGNPLAYBusinessDataLogic
{
    public class PLUGNPLAYProcess
    {
        static void DisplayItems(string category, string[] items)
        {
            Console.WriteLine($"[{category}]");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
        }

        static int GetSelection(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string GetGuitarChoice(int guitar)
        {
            return guitar switch
            {
                1 => "Fender Stratocaster",
                2 => "Fender Jaguar",
                3 => "Fender Mustang",
                4 => "Martin D-18E",
                5 => "Harmony Stella",
                6 => "1960s Epiphone",
                _ => "Invalid guitar"
            };
        }

        public static string GetPedalChoice(int pedal)
        {
            return pedal switch
            {
                7 => "Overdrive",
                8 => "Delay",
                9 => "Reverb",
                _ => "Invalid pedal"
            };
        }

        public static string GetAmplifierChoice(int amplifier)
        {
            return amplifier switch
            {
                10 => "Fender",
                11 => "Orange",
                12 => "Marshall",
                _ => "Invalid amplifier"
            };
        }
    }
}
