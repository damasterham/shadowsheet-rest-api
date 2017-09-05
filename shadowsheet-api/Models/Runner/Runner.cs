using ShadowAPI.Models.Enums;
using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Runner : BaseEntity
    {
        public User Player { get; set; }

        public virtual Info Info { get; set; }
        public virtual Attributes Attributes { get; set; }
        public virtual ICollection<RunnerSkill> Skills { get; set; } // or ICollection<Skill>
        public virtual ICollection<RunnerSkillSpecialization> SkillSpecializations { get; set; }
        public virtual ICollection<SIN> SINs { get; set; } // What binds to ids (ingame)
        public virtual ICollection<Quality> Qualities { get; set; }
        public virtual ICollection<RunnerContact> Contacts { get; set; }

        public virtual Belongings Belongings { get; set; } // Could encompass all items -> wewapons, armor aug, gear, vehicles, or perhaps this should be split up...
        public virtual Awakened Awakened { get; set; } // Encompasses all magical related entities

        //public Lifestyle Lifestyle { get; set; } // Multiple? per id? Yes if person has to pay for multiple lifestyles
        public Economy Economy { get; set; } //Inlcude credsticks in here


    }
}
