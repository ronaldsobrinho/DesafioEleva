using SchoolManager.Domain.Model;
using SchoolManager.InfraStructure.Data;
using System;
using System.Collections.Generic;

namespace SchoolManager.InfraStructure.MockProvider
{
    public class SchoolMockProvider : IProvider<SchoolModel>
    {
        private List<SchoolModel> schoolModels = new List<SchoolModel>();

        public SchoolMockProvider() {
            LoadData();
        }

        public IEnumerable<SchoolModel> GetAll()
        {
            return schoolModels; 
        }

        public void Insert(SchoolModel schoolModel)
        {
            schoolModels.Add(schoolModel);
        }

        private void LoadData()
        {
            schoolModels.AddRange(new List<SchoolModel>() { new SchoolModel() { Id = 10, Name = "Teste" } });
        }

    }
}
