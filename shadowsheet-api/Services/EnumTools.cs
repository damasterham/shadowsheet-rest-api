using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Services
{
    public static class EnumTools
    {
        public static IEnumNameable EnumNameable { get; set; }

        public static string GetName(this Enum e)
        {
           return EnumNameable.GetNameOf(e);
        }
    }
}
