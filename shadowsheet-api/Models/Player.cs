using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Player : BaseEntity // Also Identity, might conflict with inheriting class... Perhaps login credential logic and class is simply a field in player class or vice versa...
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public ICollection<Runner> Runners { get; set; }
    }
}