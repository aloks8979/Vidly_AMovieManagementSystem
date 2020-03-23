using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace VidlyClassLibrary.ViewModel
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public int RollNumber { get; set; }
        public IEnumerable<Course> Course { get; set; }
    }
}
