using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public enum Gender
    {
        Female,
        male

    }
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public Gender gender { get; set; }
       
        public DateTime Birthdate { get; set; }
    }
}