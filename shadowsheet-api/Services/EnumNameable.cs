using System;
namespace ShadowAPI.Services
{
    public class EnumNameable : IEnumNameable
    {
        public string GetNameOf(Enum e)
        {
            return e.ToString();
        }
    }
}
