using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        public List <Instructor> GetAll();
        public void Add(Instructor instructor);
        public void Update(Instructor instructor);
        public void Delete(Instructor instructor);
    }
}
