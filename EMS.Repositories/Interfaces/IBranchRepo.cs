using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Repositories.Interfaces
{
    public interface IBranchRepo
    {
        IEnumerable<Branch> GetAll();

        Branch GetById(int id);

        void Edit(Branch branch);

        void Save(Branch branch);

        void RemoveData(Branch branch);
    }
}
