namespace ShadowAPI.Models
{
    public class SkillSpecialization : BaseEntity
    {
        public string Name { get; set; }
        public Skill Skill { get; set; }
    }

}