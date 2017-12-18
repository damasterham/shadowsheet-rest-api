using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class User : NamedEntity // Also Identity, might conflict with inheriting class... Perhaps login credential logic and class is simply a field in player class or vice versa...
    {
        private string email;

        public string Email {
            get
            {
                return email;
            }
            set
            {
                email = value;
                if (IsEmailUsername)
                    Name = email;
            }
        }
        public string Password { get; set; }

        public bool IsEmailUsername { get; set; }

        //public bool IsCurrentlyPlayer { get; set; } // Or GM. A state to check if you currently are managing as player or gm
        

        public ICollection<Runner> Runners { get; set; }
        public ICollection<Campaign> Campaign { get; set; }


    
    }

}