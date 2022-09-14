using AdvAPIPractice.Models;

namespace AdvAPIPractice.DTOs
{
    public class AdvertiserReadDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
    }
}
