using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NetCoreCRUD.BackEnd.Model;
using ASP.NetCoreCRUD.Models.Context;
using ASP.NetCoreCRUD.Models.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NetCoreCRUD.Controllers
{
    public class StudentController : Controller
    {
        private CollegeContext context; 

        public StudentController(CollegeContext context)
        {
            this.context = context; 
        }
        

        public IActionResult List()
        {
            return View(context.Students.ToList());
        }

        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            context.Add(student);
            context.SaveChanges();
            return RedirectToAction("List"); 
        }

    }
}