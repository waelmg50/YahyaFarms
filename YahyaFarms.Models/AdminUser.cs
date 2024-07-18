using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahyaFarms.Models
{
    public class AdminUser
    {
        [Key]
        public int AdminUserID { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = default!;
        [Required]
        [MaxLength(50)]
        public string Password { get; set; } = default!;
        [Required]
        [MaxLength(50)]
        public string Role { get; set; } = default!;
    }
}
