using PlugAndPlay.Common;

public interface IGearRepository
{
    List<GearItem> GetGuitars();
    List<GearItem> GetPedals();
    List<GearItem> GetAmplifiers();

    void Add(GearItem item);
    bool Update(GearItem item);  
    bool Delete(int id);       
    GearItem? SearchByName(string name);
}
