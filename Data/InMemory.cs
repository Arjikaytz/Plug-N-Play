using PlugAndPlay.Common;
using System.Collections.Generic;

namespace PlugAndPlay.Data
{
    public class InMemoryMusicGearRepository
    {
        private List<GearItem> gearItems = new List<GearItem>();

        public InMemoryMusicGearRepository()
        {
            CreateDummyGearItems();
        }

        private void CreateDummyGearItems()
        {
            gearItems.Add(new GearItem(1, "Fender Stratocaster"));
            gearItems.Add(new GearItem(2, "Fender Jaguar"));
            gearItems.Add(new GearItem(3, "Fender Mustang"));

            gearItems.Add(new GearItem(4, "Martin D-18E"));
            gearItems.Add(new GearItem(5, "Harmony Stella"));
            gearItems.Add(new GearItem(6, "1960s Epiphone"));

            gearItems.Add(new GearItem(7, "Overdrive"));
            gearItems.Add(new GearItem(8, "Delay"));
            gearItems.Add(new GearItem(9, "Reverb"));

            gearItems.Add(new GearItem(10, "Fender Amp"));
            gearItems.Add(new GearItem(11, "Orange Amp"));
            gearItems.Add(new GearItem(12, "Marshall Amp"));
        }

        public List<GearItem> GetAllGearItems()
        {
            return gearItems;
        }

        public void AddGearItem(GearItem gearItem)
        {
            // TODO: Add validation if necessary
            gearItems.Add(gearItem);
        }

        public void RemoveGearItem(GearItem gearItem)
        {
            gearItems.Remove(gearItem);
        }

        public void UpdateGearItem(GearItem updatedItem)
        {
            for (int i = 0; i < gearItems.Count; i++)
            {
                if (gearItems[i].Id == updatedItem.Id)
                {
                    gearItems[i] = updatedItem;
                    break;
                }
            }
        }
    }
}
