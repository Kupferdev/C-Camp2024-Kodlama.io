using Course_Category_Instructor_Demo.DataAccess.Abstracts;
using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Title = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course1.CategoryId = 1;
            course1.Description = "Csharp";
            course1.InstructorId = 1;
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Title = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)";
            course2.Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course2.CategoryId = 1;
            course2.InstructorId = 2;
            course2.Price = 0;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Title = "Programlamaya Giriş için Temel Kurs";
            course3.Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course3.CategoryId = 1;
            course3.InstructorId = 1;
            course3.Price = 0;

            Course course4 = new Course();
            course4.Id = 4;
            course4.Title = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course4.Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course4.CategoryId = 1;
            course4.InstructorId = 1;
            course4.Price = 0;

            Course course5 = new Course();
            course5.Id = 5;
            course5.Title = "Senior Yazılım Geliştirici Yetiştirme Kampı (.Net)";
            course5.Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course5.CategoryId = 1;
            course5.InstructorId = 1;
            course5.Price = 0;

            courses = new List<Course> { course1, course2, course3, course4, course5 };
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Update(Course course)
        {
            Course existingCourse = courses.FirstOrDefault(c => c.Id == course.Id);
            if (existingCourse != null)
            {
                existingCourse.Title = course.Title;
                existingCourse.Description = course.Description;
                existingCourse.CategoryId = course.CategoryId;
                existingCourse.InstructorId = course.InstructorId;
                existingCourse.Price = course.Price;
                Console.WriteLine("Kurs başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Öge bulunamadı.");
            };
        }

        public void Delete(Course course)
        {
            Course existingCourse = courses.FirstOrDefault(c => c.Id == course.Id);
            if (existingCourse != null)
            {
                courses.Remove(existingCourse);
                Console.WriteLine("Kurs silindi.");
            }
            else
            {
                Console.WriteLine("Öge bulunamadı.");
            }
        }
    }
}
