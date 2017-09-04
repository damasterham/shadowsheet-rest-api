using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Economy : BaseEntity // Always whole nuyen!
    {
        public long CurrentFunds { get; set; } // Perhaps have a seperate Money class for storing precise values
        public ICollection<FundTransaction> History { get; set; }  // Possibly linked list

    }
}