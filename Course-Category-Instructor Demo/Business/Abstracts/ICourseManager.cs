using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.Business.Abstracts
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Update (Course course);
        void Delete(Course course);
        List<Course> GetAll();
    }
}
