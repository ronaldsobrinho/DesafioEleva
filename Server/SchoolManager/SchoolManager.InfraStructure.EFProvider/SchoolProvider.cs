using SchoolManager.Domain.Model;
using SchoolManager.InfraStructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManager.InfraStructure.EFProvider
{
    public class SchoolProvider : IProvider<SchoolModel>
    {
        private SchoolManagerContext _context;

        private SchoolProvider() { 
        }

        public SchoolProvider(SchoolManagerContext context) {
            _context = context;
        }
        
        public IEnumerable<SchoolModel> GetAll()
        {
            return _context.SchoolModel.ToList();
        }
    }
}
