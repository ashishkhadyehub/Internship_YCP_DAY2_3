using LA.Entities;
using LA.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LA.UI.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IStateRepo _stateRepo;
        private readonly IDistrictRepo _districtRepo;

        public DistrictController(IStateRepo stateRepo, IDistrictRepo districtRepo)
        {
            _stateRepo = stateRepo;
            _districtRepo = districtRepo;
        }

        public IActionResult Index()
        {
            var districts = _districtRepo.GetAll();
            return View(districts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var stateList = _stateRepo.GetAll();
            ViewBag.StateList = new SelectList(stateList,"Id","Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(District district)
        {
            _districtRepo.Save(district);
            return RedirectToAction("Index");
        }
    }
}
