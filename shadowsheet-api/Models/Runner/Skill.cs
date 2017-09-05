using ShadowAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public class Skill : NamedEntity
    {
        public SkillType Type { get; set; }
        public SkillGroup Group { get; set; }

        //Optional
        public ActiveSkillType? ActiveType { get; set; }
        public KnowledgeSkillType? KnowledgeType { get; set; }

        // Possible SkillSpecialization
        public ICollection<SkillSpecialization> Spectialization{ get; set; }

        public ICollection<RunnerSkill> Runners { get; set; } // Doesn't have to be many to many
    }
}
