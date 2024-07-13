using System.ComponentModel.DataAnnotations;

namespace YahyaFarms.DTO
{
    public class ItemImageDTO
    {
        public int ImageID { get; set; }
        [Required]
        public int ItemID { get; set; }
        [Required]
        [MaxLength(2000)]
        public string ImageURL { get; set; } = string.Empty;
    }
}
