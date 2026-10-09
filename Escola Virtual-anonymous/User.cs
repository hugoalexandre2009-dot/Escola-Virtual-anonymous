using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual_anonymous
{
    public class User
    {
        public List<Admin> ListAdmins { get; set; } = new List<Admin>();
        public List<Student> ListStudents { get; set; } = new List<Student>();
        public List<Teacher> ListTeacher { get; set; } = new List<Teacher>();

    }
    public class Admin
    {
        public string Number { get; set; }
        public string Password { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }    
        public string Number { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string phone_number { get; set; }
        public decimal nif { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string phone_number { get; set; }
        public decimal nif { get; set; }
        public string adress { get; set; }
        public string Gender { get; set; }
    }
}
