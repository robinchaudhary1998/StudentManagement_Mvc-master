using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagement_Mvc.Models;

namespace StudentManagement_Mvc.Data
{
    public class StudentManagement_MvcContext : DbContext
    {
        public StudentManagement_MvcContext (DbContextOptions<StudentManagement_MvcContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManagement_Mvc.Models.Student> Student { get; set; }

        public DbSet<StudentManagement_Mvc.Models.Course> Course { get; set; }

        public DbSet<StudentManagement_Mvc.Models.Result> Result { get; set; }
    }
}
