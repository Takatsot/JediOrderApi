using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JediOrderApi.Models.Domain
{
    public class Images : Entity
    {
        [NotMapped]
        public required IFormFile File { get; set; }
        public required string FileName { get; set; }
        public  string? Description { get; set; }
        public required string Extension { get; set; }
        public long SizeInBytes { get; set; }
        public required string Path { get; set; }

        // Optional navigation property to the product
        public int? ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [JsonIgnore]
        public Products? Product { get; set; }
    }
}
