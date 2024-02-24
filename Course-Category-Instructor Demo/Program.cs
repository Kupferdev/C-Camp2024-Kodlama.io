using Course_Category_Instructor_Demo.Business;
using Course_Category_Instructor_Demo.Business.Abstracts;
using Course_Category_Instructor_Demo.Business.Concretes;
using Course_Category_Instructor_Demo.DataAccess.Abstracts;
using Course_Category_Instructor_Demo.DataAccess.Concretes;
using Course_Category_Instructor_Demo.Entities;
using System.ComponentModel;
// Day 2 - Work 3

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();

Course course6 = new Course
{
    Id = 6,
    Title = "Sql",
    Description = "Sql İle veritabanı yönetimi",
    CategoryId = 1,
    InstructorId = 1,
    Price = 100
};
courseManager.Add(course6);

foreach (Course course in courses)
{
    Console.WriteLine(course.Id + " - " + course.Title + " - " + course.Description);
}



Instructor instructor3 = new Instructor();
instructor3.Id = 3;
instructor3.Name = "Ahmet";
instructor3.About = "github/kupferdev";

InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

instructorManager.Add(instructor3);

Instructor updateInstructor = new Instructor();
updateInstructor.Id = 3;
updateInstructor.Name = "Mehmet";
updateInstructor.About = "Uzun zamandır Sql üzerine çalışıyorum.";
instructorManager.Update(updateInstructor);

foreach (var instructor in instructors)
{
    Console.WriteLine(instructor.Id + " - " + instructor.Name + " - " + instructor.About);
}



CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

categoryManager.Add(new Category { Id = 3, Kind = "Web Geliştirme" });

foreach (var category in categories)
{
    Console.WriteLine(category.Kind);
}
