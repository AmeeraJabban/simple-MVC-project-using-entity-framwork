using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set;}

        [Required]
        [Display(Name="Student First Name")]
        public string fname { get; set; }

        [Required]
        [Display(Name = "Student Middle Name")]
        public string mname { get; set; }

        [Required]
        [Display(Name = "Student Last Name")]
        public string lname { get; set; }

        [Display(Name = "Student Gender")]
        public int gender { get; set; }

        public bool Active { get; set; }

        public int ClassID { get; set; }
        public Classes classprop { get; set; }
    }
}