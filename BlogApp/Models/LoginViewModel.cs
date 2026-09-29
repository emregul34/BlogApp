using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Eposta")]
        public string? Email
        {
            get;
            set;
        }

        [Required]
        [StringLength(10, ErrorMessage = "{0} en az {2} ve en fazla {1} karakter olmalıdır.", MinimumLength = 6)]
        [Display(Name = "Parola")]           
        [DataType(DataType.Password)]   
        public string? Password
        {
            get;
            set;
        }
    }
}
