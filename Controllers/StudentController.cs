using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class StudentController : Controller
	{
		
		private static List<Student> Students = new List<Student>();

		
		public IActionResult Index()
		{
			return View();
		}

		
		[HttpPost]
		public IActionResult Index(Student student)
		{
			if (ModelState.IsValid)
			{
				Students.Add(student);
				return RedirectToAction("ShowKQ", student); 
			}
			return View(student);
		}

		
		public IActionResult ShowKQ(Student student)
		{
			
			int count = Students.Count(s => s.ChuyenNganh == student.ChuyenNganh);
			ViewBag.Count = count; 
			ViewBag.AllStudents = Students; 
			return View(student); 
		}
	}
}