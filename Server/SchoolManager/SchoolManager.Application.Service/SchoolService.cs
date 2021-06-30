using SchoolManager.Domain.Model;
using SchoolManager.Domain.Model.Contracts;
using SchoolManager.InfraStructure.Data;
using System.Collections.Generic;

namespace SchoolManager.Application.Service
{
    public class SchoolService:ISchoolService
    {                
        public IEnumerable<ISchool> GetAll() {

            return RepositoryFactory.GetSchoolRepository().GetAll();
        }

    }
}
