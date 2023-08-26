namespace BAAS.Model
{
    public class SubmarineMart: BaseEntity
    {
        public string Name { get; set; }
        public List<Submarine> Submarines { get; set; }
    }
}
