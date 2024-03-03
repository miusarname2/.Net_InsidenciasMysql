using System.ComponentModel.DataAnnotations;

namespace InsidenciasMysql.Model.DataModels
{
    public class Insidences : BaseEntity
    {
        public Category category { get; set; } = new Category();
        public TypeOfInsidence typeOfInsidence { get; set; }
        public Area area { get; set; } = new Area();
        [Required]
        public string venueSpecific { get; set; } = string.Empty;

        [Required,StringLength(90)]
        public string reporterName { get; set; } = string.Empty;
    }
}
