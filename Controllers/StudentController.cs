using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        
        public static List<Student> StudentList = new List<Student>();

        public IActionResult Index()
        {
            
            ViewBag.ChuyenNganhList = new SelectList(new List<string> { "CNPM", "HTTT", "ANM", "TTNT", "MMT" });
            return View();
        }

        [HttpPost]
        public IActionResult ShowKQ(Student student)
        {
            if (ModelState.IsValid)
            {
                
                StudentList.Add(student);

                
                int count = StudentList.Count(s => s.ChuyenNganh == student.ChuyenNganh);

                
                ViewBag.MSSV = student.MSSV;
                ViewBag.HoTen = student.HoTen;
                ViewBag.ChuyenNganh = student.ChuyenNganh;
                ViewBag.Count = count;

                return View("ShowKQ");
            }

            
            ViewBag.ChuyenNganhList = new SelectList(new List<string> { "CNPM", "HTTT", "ANM", "TTNT", "MMT" });
            return View("Index", student);
        }
    }
}
