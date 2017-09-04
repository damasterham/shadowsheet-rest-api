using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models.Belongings
{
    public class Belongings : BaseEntity
    {
        public ICollection<Weapon> MyProperty { get; set; }
    }
}
