using System.ComponentModel.DataAnnotations;

namespace InsidenciasMysql.Model.DataModels
{
    public class Category : BaseEntity
    {
        [Required,StringLength(70)]
        public string categoryName { get; set; } = string.Empty;

        public ICollection<Insidences> Insidences { get; set; } = new List<Insidences>();
    }
}
