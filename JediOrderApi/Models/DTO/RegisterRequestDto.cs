using System.ComponentModel.DataAnnotations;

namespace JediOrderApi.Models.DTO
{
    public class RegisterRequestDto
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        public required string[] Roles { get; set; }
    }
}
