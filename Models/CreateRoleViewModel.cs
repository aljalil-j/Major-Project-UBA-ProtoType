using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Major_Project_UBA_ProtoType.Models
{
    public class CreateRoleViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string RoleName { get; set; }
    }
}
