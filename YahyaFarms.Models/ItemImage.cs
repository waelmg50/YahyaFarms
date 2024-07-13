using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahyaFarms.Models
{
    public class ItemImage
    {
        [Key]
        public int ImageID { get; set; }
        [Required]
        public int ItemID { get; set; }
        [Required]
        [MaxLength(2000)]
        public string ImageURL { get; set; } = string.Empty;
        public bool IsMainImage { get; set; }
        public bool IsMainThumbnailImage { get; set; }
        [ForeignKey(nameof(ItemID))]
        public virtual Item ParentItem { get; set; } = new();

    }
}
