using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement_Mvc.Models
{
    //Student details
    public class Student
    {
        [Key]
        //Student ID
        public int Id { get; set; }
        //student name
        public string StudentName { get; set; }
        //student contact details
        public string ContactNumber { get; set; }
    }
}
