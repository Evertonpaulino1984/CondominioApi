using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioApi.Domain
{
    public class FlatUpdate
    {
        public string Key { get; set; }
        public DateTime Update { get; set; }
        public bool IsActive { get; set; }
        public int NumberFlat { get; set; }
        public string Quarter { get; set; }
    }
}
