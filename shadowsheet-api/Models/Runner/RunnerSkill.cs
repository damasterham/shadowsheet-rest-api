using System.Collections;
using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class RunnerSkill : BaseEntity
    {
        public long RunnerID { get; set; }
        public Runner Runner { get; set; }
        public long SkillID { get; set; }
        public Skill MyProperty { get; set; }

        public int Rating { get; set; }
        public ICollection<SkillSpecialization> Specialization { get; set; }
    }
}