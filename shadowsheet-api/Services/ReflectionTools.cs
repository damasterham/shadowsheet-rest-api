using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ShadowAPI.Services
{
    public static class ReflectionTools
    {
        public static Type[] GetTypes(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes()
                .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                .ToArray();
            // Where extends BaseEntity
        }
    }
}
