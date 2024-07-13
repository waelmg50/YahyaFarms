using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YahyaFarms.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("اسم الصنف:")]
        public string ItemName { get; set; } = string.Empty;
        [MaxLength(1000)]
        [DisplayName("الوصف:")]
        public string ItemDescription { get; set; } = string.Empty;
        [Required]
        [Column(nameof(CurrentPrice), TypeName = "decimal(8, 3)")]
        [DisplayName("السعر:")]
        public decimal CurrentPrice { get; set; }
        public virtual ICollection<ItemImage> ItemImages { get; set; } = default!;
        [NotMapped]
        public virtual List<string> ImagesUrls { get; set; } = default!;
    }
}
