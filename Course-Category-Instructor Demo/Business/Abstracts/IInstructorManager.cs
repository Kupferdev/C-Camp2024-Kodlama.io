using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.Business.Abstracts
{
    public interface IInstructorManager
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
        List<Instructor> GetAll();
    }
}
