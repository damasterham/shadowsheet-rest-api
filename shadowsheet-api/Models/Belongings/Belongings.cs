﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public class Belongings : BaseEntity
    {
        public override long ID { get => base.ID; set => base.ID = value; }
        //public ICollection<Weapon> Weapons { get; set; }
        public Runner Runner { get; set; }
    }
}
