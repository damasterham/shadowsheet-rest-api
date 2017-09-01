using ShadowAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public class Skill : BaseEntity
    {
        public String Name { get; set; }
        public int Rating { get; set; }
        public SkillType Type { get; set; }
        public SkillGroup Group { get; set; }

        //Optional
        public ActiveSkillType? ActiveType { get; set; }
        public KnowledgeSkillType? KnowledgeType { get; set; }
        public ICollection<SkillSpecialization> Specialization { get; set; }

    }
}
