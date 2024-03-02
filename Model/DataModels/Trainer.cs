using System.ComponentModel.DataAnnotations;

namespace InsidenciasMysql.Model.DataModels
{
    public class Trainer : BaseEntity
    {
        [Required, StringLength(90)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(90)]
        public string lastname { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;
    }
}
