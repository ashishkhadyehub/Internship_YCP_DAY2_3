using LA.Entities;
using LA.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LA.UI.Controllers
{
    public class StateController : Controller
    {
        private readonly ICountryRepo _countryRepo;
        private readonly IStateRepo _stateRepo;

        public StateController(ICountryRepo countryRepo, IStateRepo stateRepo)
        {
            _countryRepo = countryRepo;
            _stateRepo = stateRepo;
        }

        public IActionResult Index()
        {
            var states = _stateRepo.GetAll();
            return View(states);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var countryList = _countryRepo.GetAll();
            ViewBag.CountryList = new SelectList(countryList,"Id","Name") ;
            return View();
        }

        [HttpPost]
        public IActionResult Create(State state)
        {
            _stateRepo.Save(state);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var countryList = _countryRepo.GetAll();
            ViewBag.CountryList = new SelectList(countryList,"Id","Name");

            var state = _stateRepo.GetById(id);
            return View(state);
        }

        [HttpPost]
        public IActionResult Edit(State state)
        {
            _stateRepo.Edit(state);
            return RedirectToAction("Index");
        }
    }
}
