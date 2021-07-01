using SchoolManager.Domain.Business.Repositories;
using SchoolManager.Domain.Contracts;
using SchoolManager.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManager.Application.Service.Handlers
{
    public class ClassService : IClassService
    {
        private IClassRepository<ClassModel> _repository;

        public ClassService(IClassRepository<ClassModel> classRepository) {
            _repository = classRepository;
        }

        public void Add(ClassModel classModel) {         
            _repository.Add(classModel);
        }

        public IEnumerable<ClassModel> GetAll(int schoolId){
            return _repository.GetAll(schoolId);
        }
}
}
