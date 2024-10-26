using System.ComponentModel.DataAnnotations;

namespace JediOrderApi.Models.Domain
{
    public abstract class Entity
    {
        [Key]   
        public required int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public required string UserCreated { get; set; }
        public required string UserModified { get; set; }
        public required bool IsRetired { get; set; } = false;
    }
}
