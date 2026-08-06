using LA.Entities;
using LA.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Implementations
{
    public class StateRepo : IStateRepo
    {
        private readonly ApplicationDbcontext _context;

        public StateRepo(ApplicationDbcontext context)
        {
            _context = context;
        }

        public void Edit(State state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
        }

        public IEnumerable<State> GetAll()
        {
            return _context.States.ToList();
        }

        public State GetById(int id)
        {
            return _context.States.Find(id);
        }

        public void RemoveData(State state)
        {
            _context.States.Remove(state);
            _context.SaveChanges();
        }

        public void Save(State state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
        }
    }
}
