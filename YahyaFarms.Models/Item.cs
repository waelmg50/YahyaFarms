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
        public required string ItemName { get; set; }
        [MaxLength(1000)]
        [DisplayName("الوصف:")]
        public string ItemDescription { get; set; } = string.Empty;
        [Required]
        [Column(nameof(CurrentPrice), TypeName = "decimal(8, 3)")]
        [DisplayName("السعر:")]
        public decimal CurrentPrice { get; set; }
    }
}
