using System.ComponentModel.DataAnnotations;

namespace InsidenciasMysql.Model.DataModels
{
    public enum TOI
    {
        Hardware,
        Software,
        Both,
        Other
    }
    public class TypeOfInsidence : BaseEntity
    {
        [Required]
        public TOI TOI { get; set; } = TOI.Software;

        public ICollection<Insidences> Insidences { get; set;} = new List<Insidences>();
    }
}
