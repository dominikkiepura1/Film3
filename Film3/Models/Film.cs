namespace Film3.Models
{
    public class Film
    {
        public int ID { get; set; }
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
