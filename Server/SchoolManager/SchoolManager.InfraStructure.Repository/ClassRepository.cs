using SchoolManager.Domain.Contracts;
using SchoolManager.Domain.Models;
using SchoolManager.InfraStructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManager.InfraStructure.Repository
{
    public class ClassRepository : IClassRepository<ClassModel>
    {
        private IProvider<ClassModel> _provider;
        public ClassRepository(IProvider<ClassModel> provider) {
            _provider = provider;
        }

        public void Add(ClassModel classModel)
        {
            _provider.Insert(classModel);
        }

        public IEnumerable<ClassModel> GetAll(int schoolId)
        {
            //Todo: propagar criterio para o provedor
            return _provider.GetAll().Where(c=>c.SchoolId == schoolId);
        }
    }
}
