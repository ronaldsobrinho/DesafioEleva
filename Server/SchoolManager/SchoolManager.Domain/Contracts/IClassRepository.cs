
using System.Collections.Generic;


namespace SchoolManager.Domain.Contracts
{
    public interface IClassRepository<T>:IRepository<T>
    {
        IEnumerable<T> GetAll(int schoolId);
        void Add(T classModel);
    }
}
