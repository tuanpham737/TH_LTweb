﻿using Microsoft.AspNetCore.Mvc;
using Thuchanh_LTweb.Models;

namespace Thuchanh_LTweb.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController() {

            listStudents = new List<Student>()
            {
                new Student() { Id=101, Name ="Hải Nam", Branch = Branch.IT,
                Gender = Gender.Male, IsRegular = true,
                Address="A1-2018", Email = "nam@g.com"},
                new Student(){ Id =102, Name="Minh Tú", Branch = Branch.BE,
                Gender = Gender.Female,IsRegular = true,
                Address="A1-2019",Email="tu@g.com"},
                new Student(){ Id=103, Name="Hoàng Phong", Branch = Branch.CE,
                Gender = Gender.Male,IsRegular = false,
                Address="A1-2020",Email="phong@g.com"},
                new Student(){ Id=104, Name="Xuân Mai", Branch=Branch.EE,
                Gender= Gender.Female,IsRegular= false,
                Address="A1-2021",Email="mai@g.com" }
            };
        }
        public IActionResult Index()
        {
            return View(listStudents);
        }
    }
}