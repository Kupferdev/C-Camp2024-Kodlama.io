using Course_Category_Instructor_Demo.Business.Abstracts;
using Course_Category_Instructor_Demo.DataAccess.Abstracts;
using Course_Category_Instructor_Demo.DataAccess.Concretes;
using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.Business.Concretes
{
    public class CourseManager : ICourseManager
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
