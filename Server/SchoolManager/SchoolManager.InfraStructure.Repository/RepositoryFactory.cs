using SchoolManager.InfraStructure.EFProvider;
using SchoolManager.InfraStructure.MockProvider;
using SchoolManager.InfraStructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.InfraStructure.Data
{
    public static class RepositoryFactory
    {
        public static SchoolRepository GetSchoolRepository(int provider = 0) {
            if (provider == 1)
            {
                return new SchoolRepository(EFProvider.ProviderFactory.CreateSchoolProvider());
            }
            else {
                return new SchoolRepository(new SchoolMockProvider());
            }            
        }
    }
}
