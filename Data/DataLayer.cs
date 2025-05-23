using PlugAndPlay.Common;
using System.Collections.Generic;

namespace PlugAndPlay.Data
{
    public static class MusicGearData
    {
        public static readonly List<GearItem> ElectricGuitars = new()
        {
            new GearItem(1, "Fender Stratocaster"),
            new GearItem(2, "Fender Jaguar"),
            new GearItem(3, "Fender Mustang")
        };

        public static readonly List<GearItem> AcousticGuitars = new()
        {
            new GearItem(4, "Martin D-18E"),
            new GearItem(5, "Harmony Stella"),
            new GearItem(6, "1960s Epiphone")
        };

        public static readonly List<GearItem> Pedals = new()
        {
            new GearItem(7, "Overdrive"),
            new GearItem(8, "Delay"),
            new GearItem(9, "Reverb")
        };

        public static readonly List<GearItem> Amplifiers = new()
        {
            new GearItem(10, "Fender"),
            new GearItem(11, "Orange"),
            new GearItem(12, "Marshall")
        };
    }
}

