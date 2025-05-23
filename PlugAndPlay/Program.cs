using PLUGNPLAYBusinessDataLogic;
using PlugAndPlay.Common;
using PlugAndPlay.Data;
using System;
using System.Collections.Generic;

namespace PlugAndPlay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayItems("Electric Guitar", MusicGearData.ElectricGuitars);
            DisplayItems("Acoustic Guitar", MusicGearData.AcousticGuitars);
            DisplayItems("Pedals", MusicGearData.Pedals);
            DisplayItems("Amplifiers", MusicGearData.Amplifiers);

            int guitar = GetSelection("Pick Guitar: ");
            string guitarChoice = PLUGNPLAYProcess.GetGuitarChoice(guitar);

            int pedal = GetSelection("Pick Pedal: ");
            string pedalChoice = PLUGNPLAYProcess.GetPedalChoice(pedal);

            int amplifier = GetSelection("Pick Amplifier: ");
            string amplifierChoice = PLUGNPLAYProcess.GetAmplifierChoice(amplifier);

            Console.WriteLine($"You plugged {guitarChoice} into {pedalChoice} to {amplifierChoice}");
        }

        static void DisplayItems(string category, List<GearItem> items)
        {
            Console.WriteLine($"[{category}]");
            foreach (var item in items)
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
    }
}

