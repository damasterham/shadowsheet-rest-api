using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public class RunnerSkillSpecialization
    {
        public long RunnerID { get; set; }
        public Runner Runner { get; set; }
        public long SkillSpecializationID { get; set; }
        public SkillSpecialization SkillSpecialization { get; set; }
    }
}
