using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public class Runner
    {
        [Key]
        public long ID { get; set; }
        public virtual Info Info { get; set; }
    }
}
