using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Classes
    {
        [Key]
        public int Class_ID { get; set; }

        [Required]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        public virtual IList<Student> Students { get; set; }
    }
}