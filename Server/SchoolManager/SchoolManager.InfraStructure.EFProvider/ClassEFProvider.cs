using SchoolManager.Domain.Models;
using SchoolManager.InfraStructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManager.InfraStructure.EFProvider
{
    public class ClassEFProvider : IProvider<ClassModel>
    {
        private SchoolManagerContext _context;
        public ClassEFProvider(SchoolManagerContext context ) {
            _context = context;
        }
        public IEnumerable<ClassModel> GetAll()
        {
            //todo: segmentar provedor para padrão command. Não faz sentido recuperar tudo para filtrar em memória
            return _context.ClassModel.ToList();
        }

        public void Insert(ClassModel model)
        {
            _context.Add(model);
            _context.SaveChanges();
        }
    }
}
