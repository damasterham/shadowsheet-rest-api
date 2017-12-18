using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public abstract class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column(GetClassName())]
        public virtual long ID { get; set; }

        public string GetClassName()
        {
            return this.GetType().Name;
        }
    }
}
