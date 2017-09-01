using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public class Runner : BaseEntity
    {
        public virtual Info Info { get; set; }
        public virtual Skills Skills { get; set; } // or ICollection<Skill>
        public virtual Attributes Attributes { get; set; }
    }
}
