using dotnetCore.Training.Data;
using dotnetCore.Training.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetCore.Training.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;


        //select field and press [ctrl + .] to generate constructor
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var studentList = _context.Students.ToList();
            return View(studentList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
