using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShadowAPI.Models;

namespace ShadowAPI.Repositories
{
    public class RunnerRepo : BaseRepository<Runner, long>
    {
        public RunnerRepo(DbContext context) : base(context)
        {
        }

        public override void Create(Runner runner)
        {
            
        }
    }
}
