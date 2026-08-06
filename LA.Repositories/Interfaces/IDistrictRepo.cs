using LA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Interfaces
{
    public interface IDistrictRepo
    {
        //return type, method name (parameters)

        IEnumerable<District> GetAll();

        District GetById(int id);

        void Edit(District country);

        void Save(District country);

        void RemoveData(District country);
    }
}
