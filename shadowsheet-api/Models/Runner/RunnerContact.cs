using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models
{
    public class RunnerContact
    {
        public long RunnerID { get; set; }
        public Runner Runner { get; set; }
        public long ContactID { get; set; }
        public Contact Contact { get; set; }
        public int Loyalty { get; set; }
    }
}
