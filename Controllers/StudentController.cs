using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> students;
        public StudentController()
        {
            students = new List<Student>
            {
                new Student() { StudentId = 1, Name = "Manyaa", Branch = "CSE", Gender = "female", Section = "A" },
                new Student() { StudentId = 2, Name = "Ravi", Branch = "ECE", Gender = "male", Section = "B" },
                new Student() { StudentId = 3, Name = "Priya", Branch = "EEE", Gender = "female", Section = "C" },
                new Student() { StudentId = 4, Name = "Arjun", Branch = "ME", Gender = "male", Section = "A" },
                new Student() { StudentId = 5, Name = "Sneha", Branch = "CSE", Gender = "female", Section = "B" },
                new Student() { StudentId = 6, Name = "Vikas", Branch = "CE", Gender = "male", Section = "C" },
                new Student() { StudentId = 7, Name = "Aisha", Branch = "IT", Gender = "female", Section = "A" },
                new Student() { StudentId = 8, Name = "Raj", Branch = "ECE", Gender = "male", Section = "B" },
                new Student() { StudentId = 9, Name = "Sonal", Branch = "CSE", Gender = "female", Section = "C" },
                new Student() { StudentId = 10, Name = "Karan", Branch = "ME", Gender = "male", Section = "A" },
                new Student() { StudentId = 11, Name = "Riya", Branch = "IT", Gender = "female", Section = "B" }
            };
        }

        public ViewResult Index()
        {
            return View(students);
        }
        public ViewResult Details(int Id)
        {
            var StudentDetails=students.FirstOrDefault(std=>std.StudentId==Id);
            return View(StudentDetails);
        }
    }
}
