using PlugAndPlay.Common;

namespace PlugAndPlay.Data
{
    public class InMemoryRepository : IGearRepository
    {
        private List<GearItem> items = new List<GearItem>();
        private int nextId = 1;

        public List<GearItem> GetGuitars()
        {
            List<GearItem> result = new List<GearItem>();
            foreach (GearItem item in items)
            {
                if (item.Type == "Guitar")
                    result.Add(item);
            }
            return result;
        }

        public List<GearItem> GetPedals()
        {
            List<GearItem> result = new List<GearItem>();
            foreach (GearItem item in items)
            {
                if (item.Type == "Pedal")
                    result.Add(item);
            }
            return result;
        }

        public List<GearItem> GetAmplifiers()
        {
            List<GearItem> result = new List<GearItem>();
            foreach (GearItem item in items)
            {
                if (item.Type == "Amplifier")
                    result.Add(item);
            }
            return result;
        }

        public void Add(GearItem item)
        {
            item.Id = nextId++;
            items.Add(item);
        }

        public bool Update(GearItem item)
        {
            foreach (GearItem g in items)
            {
                if (g.Id == item.Id)
                {
                    g.Name = item.Name;
                    g.Type = item.Type;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == id)
                {
                    items.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }


        public GearItem? SearchByName(string name)
        {
            foreach (GearItem item in items)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }
    }
}