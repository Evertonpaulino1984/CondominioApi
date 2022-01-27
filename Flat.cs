using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioApi.Domain
{
    [BsonIgnoreExtraElements]
    public class Flat
    {
        public Flat()
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
        public int NumberFlat { get; set; }
        public string Quarter { get; set; }
    }
}
