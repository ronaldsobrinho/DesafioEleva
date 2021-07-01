using SchoolManager.Domain.Business.Repositories;
using SchoolManager.Domain.Model;
using SchoolManager.Domain.Model.Contracts;
using SchoolManager.InfraStructure.Data;
using System.Collections.Generic;

namespace SchoolManager.Application.Service
{
    public class SchoolService:ISchoolService
    {
        ISchoolRepository<SchoolModel> _repository;
        public SchoolService(ISchoolRepository<SchoolModel> repository) {
            _repository = repository;
        }

        public void Add(SchoolModel schoolModel)
        {
           //todo: refatorar para serviço de domínio - deve garantir que não se cadastre escola com o mesmo nome 
            _repository.Insert(schoolModel);
        }

        public IEnumerable<ISchool> GetAll() {

            //return RepositoryFactory.GetSchoolRepository().GetAll();
            return _repository.GetAll();
        }

    }
}
