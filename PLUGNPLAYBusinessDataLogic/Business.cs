namespace PLUGNPLAYBusinessDataLogic
{
    public static class PLUGNPLAYProcess
    {
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

