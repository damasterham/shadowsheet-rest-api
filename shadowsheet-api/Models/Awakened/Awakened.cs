using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Awakened : BaseEntity
    {
        public ICollection<Spell> Spells { get; set; }
        public ICollection<Ritual> Rituals { get; set; }
        public ICollection<Metamagic> Metamagics { get; set; }
        public ICollection<AdeptPower> AdeptPowers { get; set; }

        public Runner Runner { get; set; }
        // Conjuring is also a thing
    }
}