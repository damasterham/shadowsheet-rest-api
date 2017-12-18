using ShadowAPI.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShadowAPI.Models
{
    public class Runner : BaseEntity
    {
        public User User { get; set; }

        public Info Info { get; set; }
        public Attributes Attributes { get; set; }
        public ICollection<RunnerSkill> Skills { get; set; } // or ICollection<Skill>
        public ICollection<RunnerSkillSpecialization> SkillSpecializations { get; set; }
        public ICollection<RunnerQuality> Qualities { get; set; }
        public ICollection<RunnerContact> Contacts { get; set; }

        //public virtual ICollection<SIN> SINs { get; set; } // What binds to ids (ingame)


        //Ignoring collection groupings since they are complex and not needed yet
        //public Awakened Awakened { get; set; }
        //public Belongings Belongings { get; set; } 
        // Could encompass all items -> wewapons, armor aug, gear, vehicles, or perhaps this should be split up...
        // Encompasses all magical related entities

        //public Lifestyle Lifestyle { get; set; } // Multiple? per id? Yes if person has to pay for multiple lifestyles
        //public Economy Economy { get; set; } //Inlcude credsticks in here


    }
}
