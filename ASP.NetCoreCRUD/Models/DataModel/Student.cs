
//using ASP.NetCoreCRUD.BackEnd.Model;
using ASP.NetCoreCRUD.BackEnd.Model;
using ASP.NetCoreCRUD.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ASP.NetCoreCRUD.Models.DataModel
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [Required]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string MiddleName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

    }

    public class StudentRepository
    {
        private CollegeContext context; 

        public StudentRepository(CollegeContext context)
        {
            this.context = context; 
        }

        public List<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        //TODO refactor check code
        public Student GetStudent(int? Id)
        {
            if(Id != null)
            {
                var student = context.Students.Where(i => i.IdStudent == Id).FirstOrDefault();
                if(student != null)
                {
                    return student; 
                }
                throw new Exception("Student == null");


            }
            throw new Exception("Id == null");             
            
        }

        public void UpdateStudent(Student student)
        {
            if(student != null)
            {
                context.Students.Update(student);
                context.SaveChanges();
                    
            }
            else
                throw new NullReferenceException("student == null"); 
        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                context.Add(student);
                context.SaveChanges();
            }
            else
                throw new NullReferenceException("student == null");
            
        }



    }
}
