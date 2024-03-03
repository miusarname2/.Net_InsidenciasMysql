using System.ComponentModel.DataAnnotations;

namespace InsidenciasMysql.Model.DataModels
{
    public class Area : BaseEntity
    {
        [Required]
        public string nameArea = string.Empty;

        public ICollection<Insidences> insidences = new List<Insidences>();
    }
}
