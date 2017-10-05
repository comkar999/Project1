using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
       
        //navigation properties

        public List<Student> Students { get; set; }
    }
}