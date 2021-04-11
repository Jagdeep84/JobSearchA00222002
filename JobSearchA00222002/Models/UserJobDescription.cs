using JobSearchA00222002.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchA00222002.Models
{
    public class UserJobDescription : KeyAutoIncrement
    {
        public int ID { get; set; }

        [Display(Name = "Job Type")]
        public string JobType { get; set; }

        [Display(Name = "User Requirments")]
        [StringLength(4000)]
      public string UserRequirments { get; set; }
    }
}
