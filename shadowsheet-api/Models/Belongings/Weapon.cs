using ShadowAPI.Models.Enums.Belongings;

namespace ShadowAPI.Models.Belongings
{
    public abstract class Weapon : Item
    {
        public int Accuracy { get; set; }
        public int Reach { get; set; }
        public abstract int Damage { get; } // Maybe also a base damage asside this
        public DamageType DamageType { get; set; }
        public int ArmourPenetration { get; set; }
        public int MyProperty { get; set; }
    }
}