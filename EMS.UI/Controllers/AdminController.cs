using EMS.Entities;
using EMS.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EMS.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDeptRepo _deptRepo;
        private readonly IBranchRepo _branchRepo;
        private readonly IAdminRepo _adminRepo;
        public AdminController(IDeptRepo deptRepo, IBranchRepo branchRepo, IAdminRepo adminRepo)
        {
            _deptRepo = deptRepo;
            _branchRepo = branchRepo;
            _adminRepo = adminRepo;
        }


        public IActionResult Index()
        {
            var employees = _adminRepo.GetAll();
            return View(employees);
        }

        public IActionResult ApplicationList()
        {
            var leaveApps = _adminRepo.GetAllApplications();
            return View(leaveApps);
        }

        public IActionResult Edit(int id)
        {
            var appToUpdate = _adminRepo.GetById(id);   
            return View(appToUpdate);
        }

        [HttpPost]
        public IActionResult ApproveApp(LeaveApplication leaveApplication)
        {
            _adminRepo.UpdateApplication(leaveApplication.Id, "Approved");
            return RedirectToAction("ApplicationList");
        }
        [HttpPost]
        public IActionResult RejectApp(LeaveApplication leaveApplication)
        {
            _adminRepo.UpdateApplication(leaveApplication.Id, "Rejected");
            return RedirectToAction("ApplicationList");
        }
        public IActionResult BranchList()
        {
            var branches = _branchRepo.GetAll();
            return View(branches);
        }

        [HttpGet]
        public IActionResult CreateBranch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBranch(Branch branch)
        {
            _branchRepo.Save(branch);
            TempData["Message"] = "True";
            return RedirectToAction("BranchList");
        }

        [HttpGet]
        public IActionResult EditBranch(int id)
        {
            var branchToEdit = _branchRepo.GetById(id);
            return View(branchToEdit);
        }

        [HttpPost]
        public IActionResult EditBranch(Branch branch)
        {
            _branchRepo.Edit(branch);
            return RedirectToAction("BranchList");
        }

        [HttpGet]
        public IActionResult DeleteBranch(int id)
        {
            var branchToDelete = _branchRepo.GetById(id);
            _branchRepo.RemoveData(branchToDelete);
            return RedirectToAction("BranchList");
        }


        public IActionResult DeptList()
        {
            var departments = _deptRepo.GetAll();
            return View(departments);
        }

        [HttpGet]
        public IActionResult CreateDept()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDept(Department department)
        {
            _deptRepo.Save(department);
            return RedirectToAction("DeptList");
        }

        [HttpGet]
        public IActionResult EditDept(int id)
        {
            var deptToEdit = _deptRepo.GetById(id);
            return View(deptToEdit);
        }

        [HttpPost]
        public IActionResult EditDept(Department department)
        {
            _deptRepo.Edit(department);
            return RedirectToAction("DeptList");
        }

        [HttpGet]
        public IActionResult DeleteDept(int id)
        {
            var deptToDelete = _deptRepo.GetById(id);
            _deptRepo.RemoveData(deptToDelete);
            return RedirectToAction("DeptList");
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            if(admin.Username=="admin" && admin.Password=="admin")
            {
                HttpContext.Session.SetString("Admin", "True");
                return RedirectToAction("BranchList");
            }
            else
            {
                ViewData["Message"] = "Invalid Login";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
       
    }
}
