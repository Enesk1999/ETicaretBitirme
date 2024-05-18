using ETicaret.Model;
using ETicaretWebUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CategoryRepository(ApplicationDbContext rr) : base(rr)
        {
            applicationDbContext = rr;
        }

        public void Save()
        {
            applicationDbContext.SaveChanges();
        }

        public void Update(Category category)
        {
            applicationDbContext.Categoriler.Update(category);
        }
    }
}
