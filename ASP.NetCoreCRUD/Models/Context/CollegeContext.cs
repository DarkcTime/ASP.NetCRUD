using ASP.NetCoreCRUD.Models.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreCRUD.Models.Context
{
    public class CollegeContext : DbContext
    {
        public CollegeContext(DbContextOptions<CollegeContext> options) : base(options)
        {
            //create DataBase on first call 
            Database.EnsureCreated(); 
        }

        public virtual DbSet<Student> Students { get; set; }

    }
}
