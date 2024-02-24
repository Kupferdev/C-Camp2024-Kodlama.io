using Course_Category_Instructor_Demo.DataAccess.Abstracts;
using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.Name = "Engin Demiroğ";
            instructor1.About = "Engin Demiroğ YouTube kanalımda ücretsiz eğitim videoları ve içerikleri paylaşmaktayım";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.Name = "Halit Enes Kalaycı";
            instructor2.About = "kodlama.io olarak geliştirdiğimiz nArch projesinde aktif geliştirici olarak rol almaktayım.";

            instructors = new List<Instructor> { instructor1, instructor2 };
        }

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor existingInstructor = instructors.Find(i => i.Id == instructor.Id);
            if (existingInstructor != null)
            {
                instructors.Remove(existingInstructor);
                Console.WriteLine("Eğitmen eklendi.");
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı!");
            }
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            Instructor existingInstructor = instructors.Find(i => i.Id == instructor.Id);
            if (existingInstructor != null)
            {
                existingInstructor.Name = instructor.Name;
                existingInstructor.About = instructor.About;
                Console.WriteLine("Eğitmen bilgileri güncellendi.");
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı!");
            }
        }
    }
}
