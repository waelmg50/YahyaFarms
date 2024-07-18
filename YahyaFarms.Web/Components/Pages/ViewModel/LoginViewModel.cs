using System.ComponentModel.DataAnnotations;

namespace YahyaFarms.Web.Components.Pages.ViewModel
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="أدخل اسم المستخدم")]
        public string? UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "أدخل كلمة المرور")]
        public string? Password { get; set; }
    }
}
