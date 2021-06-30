using SchoolManager.InfraStructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.InfraStructure.Data
{
    public static class RepositoryFactory
    {
        public static SchoolRepository GetSchoolRepository() {
            return new SchoolRepository(EFProvider.ProviderFactory.CreateSchoolProvider());
        }
    }
}
