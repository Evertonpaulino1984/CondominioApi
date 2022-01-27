using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioApi.Domain
{
    [BsonIgnoreExtraElements]
    public class Resident
    {
        public Resident()
        {
            Key = Guid.NewGuid().ToString();
            Register = DateTime.Now;
            Update = DateTime.Now;
            IsActive = true;
        }
        public string Key { get; set; }
        public DateTime Register { get; set; }
        public DateTime Update { get; set; }
        public bool IsActive { get; set; }
        public string ResidentName { get; set; }
        public int ResidenteDocument { get; set; }
    }
}
