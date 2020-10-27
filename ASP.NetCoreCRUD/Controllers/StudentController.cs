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
        StudentRepository studentRepository; 
        
        public StudentController(CollegeContext context)
        {
            studentRepository = new StudentRepository(context); 
        }
        

        public IActionResult List()
        {
            return View(studentRepository.GetStudents());
        }

        public IActionResult Edit(int? id)
        {
            return View(studentRepository.GetStudent(id)); 
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            studentRepository.UpdateStudent(student); 
            return RedirectToAction("List"); 
        }

        public IActionResult Delete()
        {
            return View(); 
        }

        
        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            studentRepository.AddStudent(student);
            return RedirectToAction("List"); 
        }
        

    }
}