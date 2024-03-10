using System.ComponentModel.DataAnnotations;

namespace ShopSync.Domain.DTOs
{
    public class BaseEntityDTO
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime Createdat { get; set; } = DateTime.UtcNow;
        public DateTime Updatedat { get; set; } = DateTime.UtcNow;
    }
}