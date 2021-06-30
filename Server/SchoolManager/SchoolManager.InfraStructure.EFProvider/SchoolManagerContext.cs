using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;

namespace SchoolManager.InfraStructure.EFProvider
{
    public class SchoolManagerContext : DbContext
    {
        public SchoolManagerContext (DbContextOptions<SchoolManagerContext> options)
            : base(options)
        {
            
        }

        public DbSet<SchoolModel> SchoolModel { get; set; }

        
    }
}
