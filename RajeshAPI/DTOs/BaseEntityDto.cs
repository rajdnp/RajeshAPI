using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.DTOs
{
    public class BaseEntityDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
