using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class SkillSpecialization : NamedEntity
    {
        public Skill Skill { get; set; }
        public ICollection<RunnerSkillSpecialization> Runners { get; set; }
    }

}