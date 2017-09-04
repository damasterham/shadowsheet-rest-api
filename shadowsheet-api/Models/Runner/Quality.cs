namespace ShadowAPI.Models
{
    public class Quality : NamedEntity
    {
        public string Description { get; set; }
        public int Modifier { get; set; } //?
        public int Cost { get; set; }

        // Used to check if another qualitiy conflict or contracdicts this quality
        public Quality Contradictor { get; private set; } // Maybe collection?

        public bool IsPositive { get; set; }// Maybe enum using bool
    }
}