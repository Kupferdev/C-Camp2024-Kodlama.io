using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        public List<Course> GetAll();
        public void Add(Course course);
        public void Update(Course course);
        public void Delete(Course course);
    }
}
