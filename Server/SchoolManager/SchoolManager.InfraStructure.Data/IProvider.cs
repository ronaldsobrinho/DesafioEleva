using SchoolManager.Domain.Model.Contracts;

namespace SchoolManager.InfraStructure.Data
{
    public interface IProvider<T>
    {
        System.Collections.Generic.IEnumerable<T> GetAll();
        void Insert(T schoolModel);
    }
}
