using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWI.Library.Entities
{
    public class StudentModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public string Address { get; set; }

        [Display(Name = " Roll Number ")]
        public string RollNo { get; set; }

        public bool isActive { get; set; }

        [Display(Name = "Registered Date")]
        public DateTime RegisteredDate {  get; set; }

        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set;}

    }
}
