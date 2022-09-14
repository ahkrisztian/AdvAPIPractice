using System.ComponentModel.DataAnnotations;

namespace AdvAPIPractice.Models
{
    public enum SizeLookUpType
    {
        Small = 0,
        Medium = 1,
        Large = 2
    }
    public class SizeLookUp
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public SizeLookUpType SizeType { get; set; }

    }
}
