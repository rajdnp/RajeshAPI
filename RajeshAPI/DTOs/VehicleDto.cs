using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.DTOs
{
    public class VehicleDto : BaseEntityDto
    {
        public string Name { get; set; }
        public int ModelId { get; set; }
        //public ModelDto Model { get; set; }
        public ContactDetailsDto ContactDetails { get; set; }
        public ICollection<FeatureDto> Features { get; set; }
        public VehicleDto()
        {
            Features = new Collection<FeatureDto>();
        }
    }
}
