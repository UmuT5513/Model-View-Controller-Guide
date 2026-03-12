using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace hafta3.Controllers
{
    public class FirstController : Controller
    {

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
        }
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = "Ahmet", Surname = "Yılmaz", Age = 20 },
                new Student() { Id = 2, Name = "Mehmet", Surname = "Demir", Age = 22 },
                new Student() { Id = 3, Name = "Ayşe", Surname = "Kara", Age = 19 },
                new Student() { Id = 4, Name = "Fatma", Surname = "Çelik", Age = 21 },
                new Student() { Id = 5, Name = "Ali", Surname = "Öztürk", Age = 23 }
            };
            return View(students);
        }
          
    }
}
