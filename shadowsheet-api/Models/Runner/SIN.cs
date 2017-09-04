using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class SIN : NamedEntity
    {
        public ICollection<License> Licenses { get; set; }

    }
}