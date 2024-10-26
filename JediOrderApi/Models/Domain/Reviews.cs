using System.ComponentModel.DataAnnotations;

namespace JediOrderApi.Models.Domain
{
    public class Reviews : Entity
    {
        public int ProductsID { get; set; } 

        public int UserId { get; set; }
        public required string ReviewTitle { get; set; }
        public required string Comment { get; set; }
        public int Rating { get; set; }

        // Navigation property
        public Products? Products { get; set; }
    }
}
