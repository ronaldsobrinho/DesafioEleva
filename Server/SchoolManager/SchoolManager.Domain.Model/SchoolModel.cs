using SchoolManager.Domain.Model.Contracts;

namespace SchoolManager.Domain.Model
{
    public class SchoolModel : ISchool
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
