using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement_Mvc.Models
{
    //Result details
    public class Result
    {
        [Key]
        //Result ID
        public int Id { get; set; }

        [ForeignKey("Student")]
        //student Id from student
        public int StudentId { get; set; }
        //relation student
        public Student student { get; set; }

        [ForeignKey("Course")]
        //Course Id from course
        public int CourseId { get; set; }
        //relation course
        public Course course { get; set; }

        public int Marks { get; set; }
    }
}
