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
    public class ResidentRepository : IResidentRepository
    {
        private readonly IMongoCollection<Resident> _collectionResident;
        public ResidentRepository()
        {
            var client = new MongoClient(@"mongodb://localhost:27017");
            var database = client.GetDatabase("DBCRUD");
            _collectionResident = database.GetCollection<Resident>("Resident");
        }
        public Resident CreateResident(Resident resident)
        {
            _collectionResident.InsertOne(resident);

            return resident;
        }

        public string DeleteResident(string residentKey)
        {
            throw new NotImplementedException();
        }

        public List<Resident> GetResident()
        {
            var residents = _collectionResident.Find(b => b.IsActive).ToList();

            return residents;
        }

        public Resident GetResidentByKey(string residentKey)
        {
            var resident = _collectionResident.Find(p => p.Key == residentKey).FirstOrDefault();

            return resident; 
        }

        public Resident UpdateResident(Resident resident)
        {
            _collectionResident.ReplaceOneAsync(c => c.Key == resident.Key, resident);

            return resident;
        }
    }
}
