using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWI.Library.Entities
{
    internal class BookCategoryModel
    {
        public int Id { get; set; }
        [Required]
        public int code { get; set; }
        public string Name { get; set; }

    }
}
