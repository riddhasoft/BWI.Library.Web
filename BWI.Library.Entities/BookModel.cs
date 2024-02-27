using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BWI.Library.Entities
{
    internal class BookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateOnly PublicationDate { get; set; }
        public string Edition { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
        [ForeignKey("BookCategory")]
        public int BookCategoryId { get; set; }
        [ValidateNever]
        public virtual BookCategoryModel BookCategory { get; set; }
    }
}
