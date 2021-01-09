using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.DTOs
{
    public class ModelDto : BaseEntityDto
    {
        public string Name { get; set; }
        public int MakeId { get; set; }
        public MakeDto Make { get; set; }
        public ICollection<FeatureDto> Features { get; set; }
    }
}
