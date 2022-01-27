using CondominioApi.Core.Interface;
using CondominioApi.Domain;
using CondominioApi.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioApi.Core
{
    public class FlatService : IFlatService
    {
        private readonly IFlatRepository _flatRepository;
        public FlatService(IFlatRepository flatRepository)
        {
            _flatRepository = flatRepository;
        }
        public Flat CreateFlat(Flat flat)
        {
            return _flatRepository.CreateFlat(flat);
        }

        public string DeleteCar(string flatKey)
        {
            throw new NotImplementedException();
        }

        public Flat GetFlatByKey(string flatKey)
        {
            var flat = _flatRepository.GetFlatByKey(flatKey);

            return flat;
        }

        public List<Flat> GetFlats()
        {
            var flats = _flatRepository.GetFlats();

            return flats;
        }

        public Flat UpdateFlat(Flat flat)
        {
            return _flatRepository.UpdateFlat(flat);
        }
    }
}
