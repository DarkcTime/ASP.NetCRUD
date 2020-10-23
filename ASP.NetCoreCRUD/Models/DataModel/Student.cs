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
}
