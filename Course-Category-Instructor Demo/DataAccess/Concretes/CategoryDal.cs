using Course_Category_Instructor_Demo.DataAccess.Abstracts;
using Course_Category_Instructor_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Category_Instructor_Demo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {
            Category category1 = new Category { Id = 0, Kind = "Tümü" };
            Category category2 = new Category { Id = 1, Kind = "Programlama" };

            categories = new List<Category> { category1, category2 };
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category existingCategory = categories.Find(c => c.Id == category.Id);
            if (existingCategory != null)
            {
                categories.Remove(existingCategory);
                Console.WriteLine("Kategori eklendi");
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı!");
            }
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            Category existingCategory = categories.Find(c => c.Id == category.Id);
            if (existingCategory != null)
            {
                existingCategory.Kind = category.Kind;
                Console.WriteLine("Kategori bilgileri güncellendi.");
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı!");
            }
        }
    }
}
