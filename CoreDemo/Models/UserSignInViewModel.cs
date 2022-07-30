using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lüften kullanıcı adını giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lüften şifrenizi giriniz")]
        public string password { get; set; }

    }
}
