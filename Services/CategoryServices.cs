using HocTiengAnh.Data;
using HocTiengAnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Services
{
    public class CategoryServices
    {
        private DataContext DataContext { get; set; }

        public CategoryServices() { 
            DataContext = new DataContext();
        }

        public List<CategoryModel> GetCategories()
        {
            return DataContext.Categories.ToList();
        }

        public void AddCategory(CategoryModel category)
        {
            DataContext.Categories.Add(category);
            DataContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = DataContext.Categories.Find(id);
            DataContext.Categories.Remove(category);
            DataContext.SaveChanges();
        }

        public void UpdateCategory(CategoryModel category)
        {
            var categoryUpdate = DataContext.Categories.Find(category.CategoryID);
            categoryUpdate.CategoryName = category.CategoryName;
            DataContext.SaveChanges();
        }
    }
}
