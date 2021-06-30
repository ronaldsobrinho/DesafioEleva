using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.Domain.Model.Contracts
{
    public interface ISchool
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
