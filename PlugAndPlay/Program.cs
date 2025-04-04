using PLUGNPLAYBusinessDataLogic;

namespace PlugAndPlay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] electricGuitars = new string[] { "[1] Fender Stratocaster", "[2] Fender Jaguar", "[3] Fender Mustang" };
            string[] acousticGuitars = new string[] { "[4] Martin D-18E", "[5] Harmony Stella", "[6] 1960s Epiphone" };
            string[] pedals = new string[] { "[7] Overdrive", "[8] Delay", "[9] Reverb" };
            string[] amplifiers = new string[] { "[10] Fender", "[11] Orange", "[12] Marshall" };

            DisplayItems("Electric Guitar", electricGuitars);
            DisplayItems("Acoustic Guitar", acousticGuitars);
            DisplayItems("Pedals", pedals);
            DisplayItems("Amplifiers", amplifiers);

            int guitar = GetSelection("Pick Guitar: ");

            string guitarChoice = PLUGNPLAYProcess.GetGuitarChoice(guitar); 

            int pedal = GetSelection("Pick Pedal: ");

            string pedalChoice = PLUGNPLAYProcess.GetPedalChoice(pedal);

            int amplifier = GetSelection("Pick Amplifier: ");

            string amplifierChoice = PLUGNPLAYProcess.GetAmplifierChoice(amplifier);

            Console.WriteLine("You plugged "+ guitarChoice+ " into " +pedalChoice+" to "+amplifierChoice);
        }

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
    }

}
