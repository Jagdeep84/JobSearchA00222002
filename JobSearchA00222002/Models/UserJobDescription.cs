using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchA00222002.Models
{
    public class UserJobDescription
    {
        public int ID { get; set; }

        public string JobType { get; set; }

        [StringLength(4000)]
      public string UserRequirments { get; set; }
    }
}
