using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [StringLength(8, MinimumLength = 4, ErrorMessage = "La contraseña debe tener entre 4 y 8 caracteres.")]
        public string Password { get; set; }
    }
}