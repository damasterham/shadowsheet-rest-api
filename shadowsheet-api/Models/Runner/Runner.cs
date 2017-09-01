using ShadowAPI.Models.Enums;
using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Runner : BaseEntity
    {
        public Player Player { get; set; }

        public virtual Info Info { get; set; }
        public virtual Skills Skills { get; set; } // or ICollection<Skill>
        public virtual Attributes Attributes { get; set; }
        public virtual ICollection<Identification> Ids { get; set; } // What binds to ids (ingame)
        public virtual ICollection<Quality> Qualities { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }

        public virtual string Belongings { get; set; } // Could encompass all items -> wewapons, armor aug, gear, vehicles, or perhaps this should be split up...
        public virtual Awakened Awakened { get; set; } // Encompasses all magical related entities

        public Lifestyle Lifestyle { get; set; } // Multiple? per id?
        public Economy Economy { get; set; }


    }
}
