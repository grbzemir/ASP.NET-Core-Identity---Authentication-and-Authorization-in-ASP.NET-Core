using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Identity.ViewModels
{
    public class Register
    {

        [Required]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage =  "Password and confiramtion pass")]


        public string ConfirmPassword { get; set; }
    }
}
