using InsidenciasMysql.Model.DataModels;
using Microsoft.EntityFrameworkCore;

namespace InsidenciasMysql.DataAccess
{
    public class InsidencesDbContext : DbContext
    {
        public InsidencesDbContext(DbContextOptions<InsidencesDbContext> options ):base(options) {
        
        }

        public DbSet<Trainer>? Trainers {  get; set; } 
        public DbSet<Area>? Area { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<Insidences>? Insidences { get; set;}
        public DbSet<TypeOfInsidence>? InsidencesTypes { get; set; }
    }
}
