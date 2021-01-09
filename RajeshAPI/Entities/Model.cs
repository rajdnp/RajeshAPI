using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.Entities
{
    public class Model : BaseEntity
    {
        public string Name { get; set; }
        public int MakeId { get; set; }
        public Make Make { get; set; }
        public ICollection<Feature> Features { get; set; }
    }
}
