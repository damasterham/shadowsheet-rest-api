using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Identification
    {
        public string Name { get; set; }
        public ICollection<License> Licenses { get; set; }

    }
}