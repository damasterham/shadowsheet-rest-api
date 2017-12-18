using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public class Belongings : BaseEntity
    {
        //public ICollection<Weapon> Weapons { get; set; }
        public Runner Runner { get; set; }
    }
}
