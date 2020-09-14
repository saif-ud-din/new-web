using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net;

namespace Saifudin.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string fathername { get; set; }
        public string Gender { get; set; }
        public string proggram { get; set; }
        public decimal marks { get; set; }
    }
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }


}