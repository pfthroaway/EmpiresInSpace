using EmpiresInSpace.Enums;

namespace EmpiresInSpace.Entities
{
    public class Star : StellarObject
    {
        public Color Color { get; set; }
        public Luminosity Luminosity { get; set; }
    }
}