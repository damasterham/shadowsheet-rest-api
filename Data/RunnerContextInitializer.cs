using ShadowAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Data
{
    public static class RunnerContextInitializer
    {
        public static void Initialize(RunnerContext context)
        {
            context.Database.EnsureCreated();

            context.Runner.Add(new Runner());
        }
    }
}
