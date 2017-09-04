using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class User : NamedEntity // Also Identity, might conflict with inheriting class... Perhaps login credential logic and class is simply a field in player class or vice versa...
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public bool IsCurrentlyPlayer { get; set; } // Or GM. A state to check if you currently are managing as player or gm
        

        public ICollection<Runner> Runners { get; set; }
        public ICollection<Campaign> Campaign { get; set; }
    }
}