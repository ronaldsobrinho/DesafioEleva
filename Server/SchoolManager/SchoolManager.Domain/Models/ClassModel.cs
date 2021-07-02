namespace SchoolManager.Domain.Models
{
    public class ClassModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentQuantity { get; set; }
        public int SchoolId { get; set; }
    }
}
