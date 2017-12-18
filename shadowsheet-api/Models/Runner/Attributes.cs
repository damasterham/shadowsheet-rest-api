using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ShadowAPI.Models
{
    public class Attributes : BaseEntity
    {
        public int Body { get; set; }
        public int Agility { get; set; }
        public int Reaction { get; set; }
        public int Strength { get; set; }
        public int Willpower { get; set; }
        public int Logic { get; set; }
        public int Intuition { get; set; }
        public int Charisma { get; set; }
        public int Edge { get; set; }
        public float Essence { get; set; }
        public int Magic { get; set; }
        public int Resonance { get; set; }

        //[BindNever]
        public Runner Runner { get; set; }
    }
}