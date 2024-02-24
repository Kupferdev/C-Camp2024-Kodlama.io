using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        public List<Category> GetAll();
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(Category category);
    }
}
