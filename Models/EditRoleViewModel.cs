using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Major_Project_UBA_ProtoType.Models
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        //internal string id;

        public String Id { get; set; }

        [Required(ErrorMessage = "Role Name is required")]
        public String RoleName { get; set; }

        public List<String> Users { get; set; }
    }
}
