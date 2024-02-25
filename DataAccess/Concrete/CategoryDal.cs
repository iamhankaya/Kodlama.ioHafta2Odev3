using Kodlama.ioHafta2Odev3.DataAccess.Abstract;
using Kodlama.ioHafta2Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioHafta2Odev3.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal() 
        {
            Category category = new Category()
            {
                Id = 1, Name= "Yazılım"
            };

            categories = new List<Category> { category };
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }
    }
}
