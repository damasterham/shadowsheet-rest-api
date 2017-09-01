using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Economy // Always whole nuyen!
    {
        public long CurrentFunds { get; set; }
        public ICollection<FundTransaction> History { get; set; }  // Possibly linked list

    }
}