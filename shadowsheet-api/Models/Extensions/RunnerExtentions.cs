using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Models.Extensions
{
    public static class RunnerExtentions
    {
        public static void ClearNavigationProps(this Runner runner)
        {
            runner.Attributes.Runner = null;
            runner.Info.Runner = null;
        }
    }
}
