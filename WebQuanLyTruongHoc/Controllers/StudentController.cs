using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuanLyTruongHoc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllStudents()
        {
            return View();
        }
        public IActionResult AddStudents()
        {
            return View();
        }
    }
}
