using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowAPI.Models
{
    public class Awakened : BaseEntity
    {
        public override long ID { get => base.ID; set => base.ID = value; }

        public ICollection<Spell> Spells { get; set; }
        public ICollection<Ritual> Rituals { get; set; }
        public ICollection<Metamagic> Metamagics { get; set; }
        public ICollection<AdeptPower> AdeptPowers { get; set; }

        public Runner Runner { get; set; }
        // Conjuring is also a thing
    }
}