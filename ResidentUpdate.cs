using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioApi.Domain
{
    public class ResidentUpdate
    {
        public string Key { get; set; }
        public DateTime Update { get; set; }
        public bool IsActive { get; set; }
        public string ResidentName { get; set; }
        public int ResidenteDocument { get; set; }
    }
}
