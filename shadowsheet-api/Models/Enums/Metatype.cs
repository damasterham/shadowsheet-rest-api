using ShadowAPI.Services;

namespace ShadowAPI.Models
{
    public enum Metatype : byte
    {
        Human,
        Elf,
        Dwarf,
        Orc,
        Troll
    }

    class MyClass
    {
        public void bla()
        {
            Metatype.Dwarf.GetName();
        }
    }
}