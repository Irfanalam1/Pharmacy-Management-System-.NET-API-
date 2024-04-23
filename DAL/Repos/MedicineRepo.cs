using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MedicineRepo : Repo, IRepo<Medicine, int, bool>
    {
        public bool Create(Medicine obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> Get()
        {
            throw new NotImplementedException();
        }

        public Medicine Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Medicine obj)
        {
            throw new NotImplementedException();
        }

        bool IRepo<Medicine, int, bool>.Create(Customer data)
        {
            throw new NotImplementedException();
        }
    }
}
