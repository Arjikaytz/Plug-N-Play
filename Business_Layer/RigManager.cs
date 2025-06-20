using PlugAndPlay.Common;
using System.Collections.Generic;

namespace PlugAndPlay.Business
{
    public class RigManager
    {
        private IGearRepository _repository;

        public RigManager(IGearRepository repository)
        {
            _repository = repository;
        }

        public List<GearItem> GetGuitars()
        {
            return _repository.GetGuitars();
        }

        public List<GearItem> GetPedals()
        {
            return _repository.GetPedals();
        }

        public List<GearItem> GetAmplifiers()
        {
            return _repository.GetAmplifiers();
        }

        public void AddGear(GearItem item)
        {
            _repository.Add(item);
        }

        public void UpdateGear(GearItem item)
        {
            _repository.Update(item);
        }

        public void DeleteGear(int id)
        {
            _repository.Delete(id);
        }

        public GearItem SearchGear(string name)
        {
            return _repository.SearchByName(name);
        }
    }
}
