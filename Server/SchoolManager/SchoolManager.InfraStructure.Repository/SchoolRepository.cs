using SchoolManager.Domain.Business.Repositories;
using SchoolManager.Domain.Model;
using SchoolManager.Domain.Model.Contracts;
using SchoolManager.InfraStructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.InfraStructure.Repository
{
    public class SchoolRepository:ISchoolRepository<SchoolModel>
    {
        IProvider<SchoolModel> _provider;

        private SchoolRepository() { 
        
        }
        public SchoolRepository(IProvider<SchoolModel> provider) {
            _provider = provider;
        }

        public IEnumerable<ISchool> GetAll()
        {
            return _provider.GetAll();
        }

        public void Insert(SchoolModel schoolModel)
        {            
            _provider.Insert(schoolModel);
        }
    }
}
