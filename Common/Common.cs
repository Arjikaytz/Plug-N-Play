namespace PlugAndPlay.Common
{
    public class GearItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public GearItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"[{Id}] {Name}";
    }
}
