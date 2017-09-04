using ShadowAPI.Models.Enums.Belongings;

namespace ShadowAPI.Models.Belongings
{
    public abstract class Item : NamedEntity
    {
        public int Availability { get; set; }
        public long Cost { get; set; }
        public ItemGroup ItemGroup { get; set; }
        public ItemType  ItemType { get; set; }


    }
}