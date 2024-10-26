using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JediOrderApi.Models.Domain
{
    public class User : IdentityRole
    {
        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [AllowNull]
        public DateTime? DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                _dateOfBirth = value;
                if (value == null) return;
                if (DateTime.Now.Year - value.Value.Year == 0) return;
                Age = DateTime.Now.AddYears(-value.Value.Year).Year;
            }
        }

        private DateTime? _dateOfBirth { get; set; }

        [AllowNull]
        public int? Age { get; private set; }

        //[Required]
        //public int AccountId { get; set; }

        //[ForeignKey(nameof(AccountId))]
        //public Account? Account { get; set; }
    }
}
