using System.Collections.Generic;

namespace ShadowAPI.Models
{
    public class Contact : NamedEntity
    {
        public int Connection { get; set; }
        public string Favor { get; set; } //huh?

        public ICollection<RunnerContact> Runners { get; set; }
    }
}