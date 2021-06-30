using SchoolManager.Domain.Model.Contracts;
using System.Collections.Generic;

namespace SchoolManager.Domain.Business.Repositories
{
    public interface ISchoolRepository: ICommand , IQuery<ISchool>
    {
        IEnumerable<ISchool> GetAll();
    }
}
