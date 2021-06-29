using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Presentation.WebAPI.Models;

namespace SchoolManager.Presentation.WebAPI.Data
{
    public class SchoolManagerPresentationWebAPIContext : DbContext
    {
        public SchoolManagerPresentationWebAPIContext (DbContextOptions<SchoolManagerPresentationWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolManager.Presentation.WebAPI.Models.SchoolModel> SchoolModel { get; set; }
    }
}
