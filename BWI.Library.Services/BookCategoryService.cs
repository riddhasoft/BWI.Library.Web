using BWI.Library.Entities;
using BWI.Library.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWI.Library.Services
{
    public class BookCategoryService : IBookCategoryService
    {
        readonly MyDBContext _dbContext;
        public BookCategoryService(MyDBContext db)
        {
            _dbContext = db;
        }
        public BookCategoryModel Add(BookCategoryModel model)
        {
            _dbContext.BookCategoryModels.Add(model);
            _dbContext.SaveChanges();
            return model;
        }

        public int Delete(int id)
        {
            var entity = _dbContext.BookCategoryModels.Find(id);
            _dbContext.BookCategoryModels.Remove(entity);
            int result = _dbContext.SaveChanges();
            return result;
        }

        public BookCategoryModel Get()
        {
            throw new NotImplementedException();
        }

        public BookCategoryModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public BookCategoryModel Update(BookCategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
