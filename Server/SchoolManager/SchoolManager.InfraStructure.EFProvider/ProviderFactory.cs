using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SchoolManager.InfraStructure.EFProvider
{
    public static class ProviderFactory
    {
        public static SchoolProvider CreateSchoolProvider()
        {
            var dboptions = new DbContextOptions<SchoolManagerContext>();
            var context = new SchoolManagerContext(dboptions);

            return new SchoolProvider(context);
        }

    }
}
