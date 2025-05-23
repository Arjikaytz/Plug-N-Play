using PlugAndPlay.Common;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PlugAndPlay.Data
{
    public class JsonFileGearDataService
    {
        static List<GearItem> gearItems = new List<GearItem>();
        static string jsonFilePath = "Data/gearitems.json";

        public JsonFileGearDataService()
        {
            ReadJsonDataFromFile();
        }

        private void ReadJsonDataFromFile()
        {
            if (!File.Exists(jsonFilePath))
            {
                gearItems = new List<GearItem>();
                return;
            }

            string jsonText = File.ReadAllText(jsonFilePath);

            gearItems = JsonSerializer.Deserialize<List<GearItem>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(gearItems, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonFilePath, jsonString);
        }

        private int FindGearItemIndex(int id)
        {
            var items = GetGearItems();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public void CreateGearItem(GearItem gearItem)
        {
            gearItems.Add(gearItem);
            WriteJsonDataToFile();
        }

        public List<GearItem> GetGearItems()
        {
            return gearItems;
        }

        public void RemoveGearItem(GearItem gearItem)
        {
            var index = FindGearItemIndex(gearItem.Id);
            if (index != -1)
            {
                gearItems.RemoveAt(index);
                WriteJsonDataToFile();
            }
        }

        public void UpdateGearItem(GearItem gearItem)
        {
            var index = FindGearItemIndex(gearItem.Id);
            if (index != -1)
            {
                gearItems[index].Id = gearItem.Id;
                gearItems[index].Name = gearItem.Name;

                WriteJsonDataToFile();
            }
        }
    }
}
