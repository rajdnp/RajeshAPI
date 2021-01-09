using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.Entities
{
    public class Make : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}
