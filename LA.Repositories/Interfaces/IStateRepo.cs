using LA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Interfaces
{
    public interface IStateRepo
    {
        //return type, method name (parameters)

        IEnumerable<State> GetAll();

        State GetById(int id);

        void Edit(State state);

        void Save(State state);

        void RemoveData(State state);
    }
}
