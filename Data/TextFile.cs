using PlugAndPlay.Common;
using System;
using System.Collections.Generic;
using System.IO;

namespace PlugAndPlay.Data
{
    public class TextFileGearDataService
    {
        string filePath = "Data/gearitems.txt";
        List<GearItem> gearItems = new List<GearItem>();

        public TextFileGearDataService()
        {
            GetDataFromFile();
        }

        private void GetDataFromFile()
        {
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                if (parts.Length == 2 &&
                    int.TryParse(parts[0].Trim(), out int id) &&
                    !string.IsNullOrWhiteSpace(parts[1]))
                {
                    gearItems.Add(new GearItem(id, parts[1].Trim()));
                }
            }
        }

        private void WriteDataToFile()
        {
            var lines = new string[gearItems.Count];

            for (int i = 0; i < gearItems.Count; i++)
            {
                lines[i] = $"{gearItems[i].Id}|{gearItems[i].Name}";
            }

            File.WriteAllLines(filePath, lines);
        }

        public int FindIndex(GearItem item)
        {
            for (int i = 0; i < gearItems.Count; i++)
            {
                if (gearItems[i].Id == item.Id)
                {
                    return i;
                }
            }

            return -1;
        }

        public List<GearItem> GetGearItems()
        {
            return gearItems;
        }

        public void CreateGearItem(GearItem gearItem)
        {
            var newLine = $"{gearItem.Id}|{gearItem.Name}";
            File.AppendAllText(filePath, newLine + Environment.NewLine);
            gearItems.Add(gearItem); // Also update in-memory list for consistency
        }

        public void UpdateGearItem(GearItem gearItem)
        {
            int index = FindIndex(gearItem);

            if (index != -1)
            {
                gearItems[index].Name = gearItem.Name;
                WriteDataToFile();
            }
        }

        public void RemoveGearItem(GearItem gearItem)
        {
            int index = FindIndex(gearItem);

            if (index != -1)
            {
                gearItems.RemoveAt(index);
                WriteDataToFile();
            }
        }
    }
}
