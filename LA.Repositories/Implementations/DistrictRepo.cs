using LA.Entities;
using LA.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Implementations
{
    public class DistrictRepo : IDistrictRepo
    {
        private readonly ApplicationDbcontext _context;
        public DistrictRepo(ApplicationDbcontext context)
        {
            _context = context;
        }

        public void Edit(District country)
        {
            _context.Districts.Update(country);
            _context.SaveChanges();
        }

        public IEnumerable<District> GetAll()
        {
            return _context.Districts.Include(x=>x.State)
                .ThenInclude(y=>y.Country)
                .ToList();
        }

        public District GetById(int id)
        {
            return _context.Districts.Find(id);
        }

        public void RemoveData(District country)
        {
            _context.Districts.Remove(country);
            _context.SaveChanges();
        }

        public void Save(District country)
        {
            _context.Districts.Add(country);
            _context.SaveChanges();
        }
    }
}
