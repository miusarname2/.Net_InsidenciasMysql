using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace InsidenciasMysql.Model.DataModels
{
    public class Insidences : BaseEntity
    {
        public Category category { get; set; } 
        public TypeOfInsidence typeOfInsidence { get; set; } 
        public Area area { get; set; } 
        [Required]
        public string venueSpecific { get; set; } = string.Empty;

        [Required,StringLength(90)]
        public string reporterName { get; set; } = string.Empty;
    }
}
