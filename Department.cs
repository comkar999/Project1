using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Department
    {


          // Scalar Properties
            public int Id { get; set; }
            public string Name { get; set; }
           

            // Navigation Property
            public List<Student> ListOfStudents { get; set; }
        

    }
}