using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace newSmartEvent.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [Display(Name="Name")]
        public string CompanyName { get; set; }
        [EmailAddress]
        [Required]
        [Display(Name ="Email")]
        public string CompanyEmail { get; set; }
        [Display(Name = "Phone")]
        public string CompanyPhone { get; set; }
        [Display(Name = "Description")]
        public string CompanyDescript { get; set; }
    }
}