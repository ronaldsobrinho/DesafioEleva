using SchoolManager.Domain.Model.Contracts;
using System.Collections.Generic;

namespace SchoolManager.Domain.Business.Repositories
{
    public interface ISchoolRepository<T>: ICommand , IQuery<T>  where T : ISchool
    {
        IEnumerable<ISchool> GetAll();
        //todo: refatorar para icommand 
        void Insert(T schoolModel);
    }
}
