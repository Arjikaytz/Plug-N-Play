namespace PlugAndPlay.Common
{
        public class GearItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }

            public GearItem() { }

            public GearItem(int id, string name, string type)
            {
                Id = id;
                Name = name;
                Type = type;
            }

            public override string ToString()
            {
               
                return $"{Id,-3} | {Name,-20} | {Type}";
            }
        }
    }
