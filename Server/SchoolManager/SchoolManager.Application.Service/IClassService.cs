using SchoolManager.Domain.Models;
using System.Collections.Generic;

namespace SchoolManager.Application.Service
{
    public interface IClassService
    {
        void Add(ClassModel classModel);
        IEnumerable<ClassModel> GetAll(int schoolId);

    }
}
