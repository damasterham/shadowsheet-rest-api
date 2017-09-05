using System.Collections;
using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class RunnerSkill
    {
        public long RunnerID { get; set; }
        public Runner Runner { get; set; }
        public long SkillID { get; set; }
        public Skill Skill { get; set; } // Doesn't have to be many to many

        public int Rating { get; set; }
        //public RunnerSkillSpecialization Specializations { get; set; } // 
    }
}