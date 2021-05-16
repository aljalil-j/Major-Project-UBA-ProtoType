using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Major_Project_UBA_ProtoType.Models
{
    public class DataModel
    {
        public int ID { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string User { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string IP_Address { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Patterns { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Location { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Home_Address { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string History { get; set; }
       


    }
}
