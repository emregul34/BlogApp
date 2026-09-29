using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string? UserName
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "Ad Soyad")]
        public string? Name
        {
            get;
            set;
        }



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

        [Required]
        [Display(Name = "Parola Tekrar")]
        [Compare(nameof(Password), ErrorMessage = "Parolalar eşleşmiyor.")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword
        {
            get;
            set;
        }


    }
}
