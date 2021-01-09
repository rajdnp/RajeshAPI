using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Name { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public ICollection<Feature> Features { get; set; }
        public Vehicle()
        {
            Features = new Collection<Feature>();
        }
    }
}
