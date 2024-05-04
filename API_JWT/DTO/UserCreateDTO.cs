using API_JWT.Enum;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace API_JWT.DTO
{
    public class UserCreateDTO
    {
        [Required(ErrorMessage = "O campo usuario é obrigatório")]
        public string User { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório"), EmailAddress (ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Password { get; set; }

        [Compare("Senha", ErrorMessage = "Senha não coincide")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "O campo cargo é obrigatório")]
        public DepartureEnum Departure { get; set; }
    }
}
