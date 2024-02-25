using Kodlama.ioHafta2Odev3.DataAccess.Abstract;
using Kodlama.ioHafta2Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioHafta2Odev3.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course = new Course()
            {
                Id=1, CategoryName="OOP", Description="asdsadas", InstructorName ="Engin Demiroğ" , Name = "C#"
            };
            Course course2 = new Course()
            {
                Id = 2,
                CategoryName = "Web",
                Description = "asdsadasasd",
                InstructorName = "Engin Demiroğ",
                Name = "Angular"
            };
            courses = new List<Course> { course, course2 };
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}
