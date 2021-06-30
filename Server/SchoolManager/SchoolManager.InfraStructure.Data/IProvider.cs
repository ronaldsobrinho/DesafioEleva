namespace SchoolManager.InfraStructure.Data
{
    public interface IProvider<T>
    {
        System.Collections.Generic.IEnumerable<T> GetAll();
    }
}
