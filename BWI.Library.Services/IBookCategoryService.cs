using BWI.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWI.Library.Services
{
    public interface IBookCategoryService
    {
        public BookCategoryModel Get();
        public BookCategoryModel Get(int id);
        public BookCategoryModel Add(BookCategoryModel model);
        public BookCategoryModel Update(BookCategoryModel model);
        public int Delete(int id);

    }
}
