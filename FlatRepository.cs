using CondominioApi.Domain;
using CondominioApi.Repository.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioApi.Repository
{
    public class FlatRepository : IFlatRepository
    {
        private readonly IMongoCollection<Flat> _collectionFlat;

        public FlatRepository()
        {
            var client = new MongoClient(@"mongodb://localhost:27017");
            var database = client.GetDatabase("DBCRUD");
            _collectionFlat = database.GetCollection<Flat>("Flat");
        }        
        
        public Flat CreateFlat(Flat flat)
        {
            _collectionFlat.InsertOne(flat);

            return flat;
        }

        public string DeleteFlat(string flatKey)
        {
            throw new NotImplementedException();
        }

        public Flat GetFlatByKey(string flatKey)
        {
            var flat = _collectionFlat.Find(p => p.Key == flatKey).FirstOrDefault();

            return flat;
        }

        public List<Flat> GetFlats()
        {
            var flats = _collectionFlat.Find(b => b.IsActive).ToList();

            return flats;
        }

        public Flat UpdateFlat(Flat flat)
        {
            _collectionFlat.ReplaceOneAsync(c => c.Key == flat.Key, flat);

            return flat;
        }
    }
}
