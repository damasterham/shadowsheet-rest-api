using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public abstract class NamedEntity : BaseEntity
    {
        public string Name { get; set; }
    }
}
