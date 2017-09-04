using System;

namespace ShadowAPI.Services
{
    public interface IEnumNameable
    {
        string GetNameOf(Enum e);
    }
}