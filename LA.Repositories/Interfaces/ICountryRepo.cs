using LA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Interfaces
{
    public interface ICountryRepo
    {
        //return type, method name (parameters)

        IEnumerable<Country> GetAll();

        Country GetById(int id);

        void Edit(Country country);

        void Save(Country country);

        void RemoveData(Country country);

    }
}
