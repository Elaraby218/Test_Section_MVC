using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using Test_Section.Models;

namespace Test_Section.Controllers
{
    public class NewStudentController : Controller
    {
        AppDbContext _appContext = new AppDbContext();
        public IActionResult AddNew(Students student)
        {
            return View();
        }

        public IActionResult AddStudent(Students student) 
        {
            _appContext.Student.Add(student);
            _appContext.SaveChanges();         
            return RedirectToAction("ShowAll");
        }

        public IActionResult ShowAll()
        {
            List<Students> students = _appContext.Student.Include(d => d.Name).ToList();
            return View(students);
        }
    }
}
