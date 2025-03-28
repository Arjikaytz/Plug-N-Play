namespace PlugAndPlay
{
    internal class Program
    {
        static string[] electricGuitars = { "1. Fender Stratocaster", "2. Fender Jaguar", "3. Fender Mustang" };
        static string[] acousticGuitars = { "1. Martin D-18E", "2. Harmony Stella", "3. 1960s Epiphone" };

        static void Main(string[] args)
        {
            Console.WriteLine("-_-_-_-_-_-_-_-_- Plug and Play -_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine(" ");

            DisplayInstrumentOptions();

            int guitarInstrument = GetUserInput();
            ProcessInstrumentChoice(guitarInstrument);

            Console.ReadKey();
        }

        static void DisplayInstrumentOptions()
        {

            Console.WriteLine("What kind of Instrument You Desired To Play?");
            Console.WriteLine("1: Electric Guitar");
            Console.WriteLine("2: Acoustic Guitar");

        }

        static int GetUserInput()
        {
            Console.Write("Enter your choice: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        static void ProcessInstrumentChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Electric Guitar is Your Choice.");
                    DisplayGuitarOptions(electricGuitars);
                    break;
                case 2:
                    Console.WriteLine("Acoustic Guitar is Your Choice.");
                    DisplayGuitarOptions(acousticGuitars);
                    break;
                default:
                    TryAgainSystem();
                    break;

            }
        }



        static void DisplayGuitarOptions(string[] guitars)
        {
            Console.WriteLine("Choose:");
            foreach (var guitar in guitars)
            {
                Console.WriteLine(guitar);
            }
        }

        static void TryAgainSystem()
        {
            String input = "Y";

            while (input == "Y")
            {
                string name;
                Console.WriteLine("Invalid Input. Try Again.");
                name = Console.ReadLine();
                DisplayInstrumentOptions();

                Console.WriteLine("Would you like to enter another name? (Y/N)");
                input = Console.ReadLine();




                if (input == "N")
                {
                    Console.WriteLine("Goodbye!");
                    break;

                }
            }


        }
    }
}
