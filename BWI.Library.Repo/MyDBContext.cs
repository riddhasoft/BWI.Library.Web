using BWI.Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWI.Library.Repo
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options)
         : base(options)
        {
        }
        public DbSet<BookCategoryModel> BookCategoryModels { get; set; }
    }
}
