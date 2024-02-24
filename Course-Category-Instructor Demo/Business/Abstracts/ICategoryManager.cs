using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.Business.Abstracts
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        List<Category> GetAll();
    }
}
