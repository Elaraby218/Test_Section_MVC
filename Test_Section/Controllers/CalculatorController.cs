using Microsoft.AspNetCore.Mvc;
using Test_Section.Models;

namespace Test_Section.Controllers
{
    public class CalculatorController : Controller
    {
        Calc calc = new Calc();
        public IActionResult index()
        {
            return View(calc);
        }

        [HttpPost]
        public IActionResult DO_Calc(Calc cur)
        {
           
            TempData["a"] = cur.a;
            TempData["b"] = cur.b;
           
            
                TempData["chr"] = cur.oper;
            
            return View(cur);
        }
    }
}
