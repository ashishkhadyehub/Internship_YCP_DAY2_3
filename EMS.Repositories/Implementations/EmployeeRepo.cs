using EMS.Entities;
using EMS.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Repositories.Implementations
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<LeaveApplication> GetApplications(int empID)
        {
            var leaveApps = _context.LeaveApplications.
                Where(x=>x.EmployeeId==empID).
                ToList();
            return leaveApps;
        }

        public Employee GetById(int empID)
        {
            return _context.Employees.Find(empID);
        }

        public Employee GetUserInfo(string email, string password)
        {
            var user = _context.Employees.
                FirstOrDefault
                (x=>x.Email==email 
                && x.Password==password);
            return user;
        }

        public void RegisterEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void SubmitApplication(LeaveApplication leaveApplication)
        {
            _context.LeaveApplications.Add(leaveApplication);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }
    }
}
