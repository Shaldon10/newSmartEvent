using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace newSmartEvent.Models
{
    public class Participants
    {
        [Key]
        public int ParticipantID { get; set; }
        [Display(Name ="Name")]
        public string Part_Name { get; set; }

        public string Part_Email { get; set; }
        [Display(Name ="ID Number")]
        [StringLength(13,ErrorMessage ="ID Length must be 13 digits")]
        [RegularExpression("[^0-9]", ErrorMessage ="ID number must have numbers only")]
        public string Part_ID { get; set; }
        [Display(Name ="Phone number")]
        public string Part_No { get; set; }
        
    }
}