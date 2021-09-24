using EmpiresInSpace.Enums;
using System.Collections.Generic;

namespace EmpiresInSpace.Entities
{
    public class Planet : StellarObject
    {
        public Atmosphere Atmosphere { get; set; }
        public Composition Composition { get; set; }
        public Conditions Conditions { get; set; }
        public int Minerals { get; set; }
        public int Radioactives { get; set; }
        public int Organics { get; set; }
        public int Population { get; set; }
        public List<Facility> Facilities { get; set; }
        public List<StorableItem> Cargo { get; set; }
    }
}