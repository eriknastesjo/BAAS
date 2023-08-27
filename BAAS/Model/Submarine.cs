namespace BAAS.Model
{
    public class Submarine: BaseEntity
    {
        public string Name { get; set; }
        public float MaxSpeedKmPerHour { get; set; }
        public float MaxDepthM { get; set; }
        public string Description { get; set; }
    }
}
