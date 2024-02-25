using Kodlama.ioHafta2Odev3.Business;
using Kodlama.ioHafta2Odev3.DataAccess.Abstract;
using Kodlama.ioHafta2Odev3.DataAccess.Concrete;
using Kodlama.ioHafta2Odev3.Entities;

InstructorManager instructorManager = new(new InstructorDal());
CategoryManager categoryManager = new(new CategoryDal());
CourseManager courseManager = new(new CourseDal());

List<Instructor> instructors = instructorManager.GetAll();
List <Category> categories = categoryManager.GetAll();
List<Course > courses = courseManager.GetAll();

Instructor instructor = new Instructor()
{
    Id = 3,
    Name = "Metehan Kaya"
};

Category category = new Category()
{
    Id = 2,
    Name = "Yazılım"
};

Course course = new Course()
{
    Name = "Senior C#",
    Id = 3,
    Description = "asdasdasdada",
    InstructorName= instructor.Name,
    CategoryName= category.Name,
};

instructorManager.Add(instructor);
categories.Add(category);
courses.Add(course);

for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i].Name);
}

for (int i = 0; i<categories.Count; i++)
{
    Console.WriteLine(categories[i].Name);
}

for(int i = 0;i<courses.Count; i++)
{
    Console.WriteLine(courses[i].Name);
}