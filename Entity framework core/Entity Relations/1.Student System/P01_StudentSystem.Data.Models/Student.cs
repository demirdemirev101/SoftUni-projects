﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }

        public ICollection<StudentCourse> StudentsCourses { get; set; }
        public ICollection<Homework> Homeworks { get; set; }

    }
}
