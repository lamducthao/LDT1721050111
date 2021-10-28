using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LDT1721050111.Models
{
    public class Person
    {
        [Key]
        [StringLength(20)]
        [Display (Name = "ID")]
        public string PersonID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên")]
        public string PersonName { get; set; }
    }
}