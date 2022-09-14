namespace AdvAPIPractice.Models
{
    public class Advertiser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
    }
}
