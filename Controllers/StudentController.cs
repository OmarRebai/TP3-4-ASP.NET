using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc.Rendering;
=======
>>>>>>> 7b0118da8645182b977e0356aa35b18177f1fb12
using TP3.Models;
using TP3.Models.Repositories;

namespace TP3.Controllers
{
    public class StudentController : Controller
    {

        readonly IStudentRepository studentRepository;
        readonly ISchoolRepository schoolRepository;

        //injection de dépendance
        public StudentController(IStudentRepository studentRepository, ISchoolRepository schoolRepository)
        {

            this.studentRepository = studentRepository;
            this.schoolRepository = schoolRepository;   

        }
        // GET: StudentController
        public ActionResult Index()
        {
            var students = studentRepository.GetAll();

            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            var student = studentRepository.GetById(id);
            return View(student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            ViewBag.SchoolID = new SelectList (schoolRepository.GetAll(),"SchoolID","SchoolName");
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
<<<<<<< HEAD
                ViewBag.SchoolID = new SelectList(schoolRepository.GetAll(), "SchoolID", "SchoolName");
=======
>>>>>>> 7b0118da8645182b977e0356aa35b18177f1fb12
                studentRepository.Add(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
<<<<<<< HEAD
            ViewBag.SchoolID = new SelectList(schoolRepository.GetAll(), "SchoolID", "SchoolName");
=======
>>>>>>> 7b0118da8645182b977e0356aa35b18177f1fb12
            var student = studentRepository.GetById(id);
            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            try
            {
<<<<<<< HEAD
                ViewBag.SchoolID = new SelectList(schoolRepository.GetAll(), "SchoolID", "SchoolName");
=======
>>>>>>> 7b0118da8645182b977e0356aa35b18177f1fb12
                studentRepository.Edit(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var student = studentRepository.GetById(id);
            return View(student);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Student student)
        {
            try
            {
                studentRepository.Delete(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
