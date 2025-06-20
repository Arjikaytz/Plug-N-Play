using PlugAndPlay.Common;

public class TextFileRepository : IGearRepository
{
    private string filePath = "gear.txt";

    private List<GearItem> Load()
    {
        List<GearItem> list = new List<GearItem>();
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    GearItem item = new GearItem(int.Parse(parts[0]), parts[1], parts[2]);
                    list.Add(item);
                }
            }
        }
        return list;
    }

    private void Save(List<GearItem> items)
    {
        List<string> lines = new List<string>();
        foreach (GearItem item in items)
        {
            lines.Add(item.Id + "," + item.Name + "," + item.Type);
        }
        File.WriteAllLines(filePath, lines);
    }

    public List<GearItem> GetGuitars()
    {
        List<GearItem> all = Load();
        List<GearItem> result = new List<GearItem>();
        foreach (GearItem item in all)
        {
            if (item.Type == "Guitar")
                result.Add(item);
        }
        return result;
    }

    public List<GearItem> GetPedals()
    {
        List<GearItem> all = Load();
        List<GearItem> result = new List<GearItem>();
        foreach (GearItem item in all)
        {
            if (item.Type == "Pedal")
                result.Add(item);
        }
        return result;
    }

    public List<GearItem> GetAmplifiers()
    {
        List<GearItem> all = Load();
        List<GearItem> result = new List<GearItem>();
        foreach (GearItem item in all)
        {
            if (item.Type == "Amplifier")
                result.Add(item);
        }
        return result;
    }

    public void Add(GearItem item)
    {
        List<GearItem> items = Load();
        int nextId = 1;
        foreach (GearItem g in items)
        {
            if (g.Id >= nextId)
                nextId = g.Id + 1;
        }
        item.Id = nextId;
        items.Add(item);
        Save(items);
    }

    public bool Update(GearItem item)
    {
        List<GearItem> items = Load();
        bool found = false;
        foreach (GearItem g in items)
        {
            if (g.Id == item.Id)
            {
                g.Name = item.Name;
                g.Type = item.Type;
                found = true;
                break;
            }
        }

        if (found) Save(items);
        return found;
    }

    public bool Delete(int id)
    {
        List<GearItem> items = Load();
        bool found = false;

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Id == id)
            {
                items.RemoveAt(i);
                found = true;
                break;
            }
        }

        if (found) Save(items);
        return found;
    }


    public GearItem? SearchByName(string name)
    {
        List<GearItem> items = Load();
        foreach (GearItem item in items)
        {
            if (item.Name == name)
                return item;
        }
        return null;
    }
}
