using InsidenciasMysql.Model.DataModels;
using Microsoft.EntityFrameworkCore;

namespace InsidenciasMysql.DataAccess
{
    public class InsidencesDbContext : DbContext
    {
        public InsidencesDbContext(DbContextOptions<InsidencesDbContext> options ):base(options) {
        
        }

        public DbSet<Trainer>? Trainers {  get; set; } 
    }
}
