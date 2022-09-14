namespace AdvAPIPractice.Models
{
    public class Advertisement
    {
        public int Id   { get; set; }
        public string Description { get; set; }

        public string ImageURL { get; set; }

        public string Size { get; set; }
        public int AdvertiserId { get; set; }
    }
}
