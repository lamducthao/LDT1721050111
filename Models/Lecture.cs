using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LDT1721050111.Models
{
    public class Lecture : Person
    {
        [StringLength(50)]
        [Display (Name = "Khoa")]
        public string Faculty { get; set; }
        [StringLength(50)]
        [Display(Name = "Phòng")]
        public string Department { get; set; }
    }
}