using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWI.Library.Entities
{
    public class BookModel
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Edition { get; set; }

        public int ISBN { get; set; }

        public DateTime PublicationDate { get; set; }

        public string  Code { get; set; }

        public bool isActive {  get; set; }

        [ForeignKey("BookCategory")]
        public int BookCategoryid { get; set; }
        
        public virtual BookCategoryModel BookCategory { get; set; }
    }
}
