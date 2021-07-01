using SchoolManager.Domain.Model;
using SchoolManager.Domain.Model.Contracts;
using System.Collections.Generic;

namespace SchoolManager.Application.Service
{
    public interface ISchoolService
    {
        IEnumerable<ISchool> GetAll();
        void Add(SchoolModel schoolModel);
    }
}
