using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement_Mvc.Models
{
    //keeps course details
    public class Course
    {
        [Key]
        //Course id
        public int Id { get; set; }

        public String CourseName { get; set; }
        //Course credits
        public int Credits { get; set; }
    }
}
