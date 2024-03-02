using System.ComponentModel.DataAnnotations;

namespace InsidenciasMysql.Model.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string createdBy { get; set; } = String.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public string updatedBy { get; set; } = String.Empty;
        public string deletedBy { get; set; } = String.Empty;
        public bool IsDeleted { get; set; } = false;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; } 
    }
}
