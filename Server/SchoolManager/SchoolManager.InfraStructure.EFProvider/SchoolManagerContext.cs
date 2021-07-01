using Microsoft.EntityFrameworkCore;
using SchoolManager.Domain.Model;
using SchoolManager.Domain.Models;

namespace SchoolManager.InfraStructure.EFProvider
{
    public class SchoolManagerContext : DbContext
    {
        public SchoolManagerContext (DbContextOptions<SchoolManagerContext> options)
            : base(options)
        {
            
        }

        public DbSet<SchoolModel> SchoolModel { get; set; }
        public DbSet<ClassModel> ClassModel { get; set; }

        
    }
}
